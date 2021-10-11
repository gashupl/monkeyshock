import {IInputs, IOutputs} from "./generated/ManifestTypes";
import { XrmClient } from "./xrmClient";

const smileImagePath : string = "/WebResources/pg_/img/controls/smile.jpg";
const sadImagePath : string = "/WebResources/pg_/img/controls/sad.jpg";

export class HappyFace implements ComponentFramework.StandardControl<IInputs, IOutputs> {

	private context: ComponentFramework.Context<IInputs>;
	private container: HTMLDivElement;
	private notifyOutputChanged: () => void;
	private xrmClient : XrmClient; 
	private entityId: string; 

	private smileImgElement : HTMLImageElement; 
	private sadImgElement : HTMLImageElement;

	constructor()
	{

	}

	/**
	 * Used to initialize the control instance. Controls can kick off remote server calls and other initialization actions here.
	 * Data-set values are not initialized here, use updateView.
	 * @param context The entire property bag available to control via Context Object; It contains values as set up by the customizer mapped to property names defined in the manifest, as well as utility functions.
	 * @param notifyOutputChanged A callback method to alert the framework that the control has new outputs ready to be retrieved asynchronously.
	 * @param state A piece of data that persists in one session for a single user. Can be set at any point in a controls life cycle by calling 'setControlState' in the Mode interface.
	 * @param container If a control is marked control-type='standard', it will receive an empty div element within which it can render its content.
	 */
	public init(context: ComponentFramework.Context<IInputs>, notifyOutputChanged: () => void, state: ComponentFramework.Dictionary, container:HTMLDivElement): void
	{
		console.log("init..."); 
		this.context = context;
		this.entityId = context.parameters.Id.raw as string;  
		this.container = container;
		this.notifyOutputChanged = notifyOutputChanged;
		this.xrmClient = new XrmClient(); 

		this.smileImgElement = document.createElement("img");	
		this.smileImgElement.id = "imgSmile"; 
		this.smileImgElement.src = smileImagePath; 
		this.smileImgElement.style.visibility = 'hidden'; 
		
		this.sadImgElement = document.createElement("img"); 
		this.sadImgElement.id = "imgSad"; 
		this.sadImgElement.src = sadImagePath; 
		this.sadImgElement.style.visibility = 'hidden'; 

		const imagesContainer = document.createElement("div");
		imagesContainer.appendChild(this.smileImgElement); 
		imagesContainer.append("<br>"); 
		imagesContainer.appendChild(this.sadImgElement);
		this.container.appendChild(imagesContainer);
	}


	/**
	 * Called when any value in the property bag has changed. This includes field values, data-sets, global values such as container height and width, offline status, control metadata values such as label, visible, etc.
	 * @param context The entire property bag available to control via Context Object; It contains values as set up by the customizer mapped to names defined in the manifest, as well as utility functions
	 */
	public updateView(context: ComponentFramework.Context<IInputs>): void
	{
		this.xrmClient.countOpenTasks(this.entityId); 
	}

	/**
	 * It is called by the framework prior to a control receiving new data.
	 * @returns an object based on nomenclature defined in manifest, expecting object[s] for property marked as “bound” or “output”
	 */
	public getOutputs(): IOutputs
	{
		return {};
	}

	/**
	 * Called when the control is to be removed from the DOM tree. Controls should use this call for cleanup.
	 * i.e. cancelling any pending remote calls, removing listeners, etc.
	 */
	public destroy(): void
	{
		// Add code to cleanup control if necessary
	}
	
	private showError(): void
	{

	}
}
