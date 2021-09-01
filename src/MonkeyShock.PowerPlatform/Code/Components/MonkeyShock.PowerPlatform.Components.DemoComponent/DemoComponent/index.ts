import { IInputs, IOutputs } from "./generated/ManifestTypes";
import { XrmClient } from "./Internal/XrmClient";
import { ButtonFactory } from "./Internal/ButtonFactory";

export class DemoComponent implements ComponentFramework.StandardControl<IInputs, IOutputs> {

	private context: ComponentFramework.Context<IInputs>;
	private container: HTMLDivElement;
	private notifyOutputChanged: () => void;
	private isEditMode: boolean;
	private buttonClickHandler: EventListener;
	private name: string | null;
	private xrmClient : XrmClient; 
	private buttonFactory: ButtonFactory; 

	constructor() {

	}

	public init(context: ComponentFramework.Context<IInputs>, notifyOutputChanged: () => void, state: ComponentFramework.Dictionary, container: HTMLDivElement) {

		this.context = context;
		this.notifyOutputChanged = notifyOutputChanged;
		this.container = container;
		this.isEditMode = false;
		this.buttonClickHandler = this.buttonClick.bind(this);
		this.xrmClient = new XrmClient(); 
		this.buttonFactory = new ButtonFactory(); 

		// Create the span element to hold the hello message
		const message = document.createElement("span");
		message.innerText = `Hello ${this.isEditMode ? "" : context.parameters.Name.raw}`;

		// Create the textbox to edit the name
		const textbox = document.createElement("input");
		textbox.type = "text";
		textbox.style.display = this.isEditMode ? "block" : "none";
		if (context.parameters.Name.raw) {
			textbox.value = context.parameters.Name.raw;

		}
		let id = context.parameters.Id.raw; 
		const idDiv = document.createElement("div"); 
		idDiv.innerText = (id != null ? id : "Missing Id"); 

		let entityName = context.parameters.EntityName.raw
		const entityNameDiv = document.createElement("div"); 
		entityNameDiv.innerText = (entityName != null ? entityName : "Missing entity name"); 

		// Wrap the two above elements in a div to box out the content
		const messageContainer = document.createElement("div");
		messageContainer.appendChild(message);
		messageContainer.appendChild(textbox);
		messageContainer.appendChild(idDiv);
		messageContainer.appendChild(entityNameDiv);

		// Create the button element to switch between edit and read modes
		const button = document.createElement("button");
		button.textContent = this.isEditMode ? "Save" : "Edit";
		button.addEventListener("click", this.buttonClickHandler);

		// Add the message container and button to the overall control container
		this.container.appendChild(messageContainer);
		this.container.appendChild(button);

		const btnXrm = this.buttonFactory.getButton("Access XRM", this.xrmClient.createAccount);
		this.container.appendChild(btnXrm);
	}

	public buttonClick() {
		// Get our controls via DOM queries
		const textbox = this.container.querySelector("input")!;
		const message = this.container.querySelector("span")!;
		const button = this.container.querySelector("button")!;

		// If not in edit mode, copy the current name value to the textbox
		if (!this.isEditMode) {
			textbox.value = this.name ?? "";
		} else if (textbox.value != this.name) {
			// if in edit mode, copy the textbox value to name and call the motify callback
			this.name = textbox.value;
			this.notifyOutputChanged();
		}

		// flip the mode flag
		this.isEditMode = !this.isEditMode;

		// Set up the new output based on changes
		message.innerText = `Hello ${this.isEditMode ? "" : this.name}`;

		textbox.style.display = this.isEditMode ? "inline" : "none";
		textbox.value = this.name ?? "";

		button.textContent = this.isEditMode ? "Save" : "Edit";
	}

	public updateView(context: ComponentFramework.Context<IInputs>): void {
		// Checks for updates coming in from outside
		this.name = context.parameters.Name.raw;
		const message = this.container.querySelector("span")!;
		message.innerText = `Hello ${this.name}`;
	}

	public getOutputs(): IOutputs {
		return {
			// If our name variable is null, return undefined instead
			Name: this.name ?? undefined
		};
	}

	public destroy(): void {
		// Remove the event listener we created in init
		this.container.querySelector("button")!.removeEventListener("click", this.buttonClickHandler);
	}
}
