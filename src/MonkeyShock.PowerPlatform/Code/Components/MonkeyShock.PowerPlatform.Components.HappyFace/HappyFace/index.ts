import {IInputs, IOutputs} from "./generated/ManifestTypes";
import { XrmClient } from "./xrmClient";

export class HappyFace implements ComponentFramework.StandardControl<IInputs, IOutputs> {

	private context: ComponentFramework.Context<IInputs>;
	private container: HTMLDivElement;
	private notifyOutputChanged: () => void;
	private xrmClient : XrmClient; 

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
		this.context = context;
		this.container = container;
		this.notifyOutputChanged = notifyOutputChanged;
		this.xrmClient = new XrmClient(); 

		const imgSmile = document.createElement("img"); 
		imgSmile.id = "imgSmile"; 
		imgSmile.src = 'img/Smile128.png';
		imgSmile.style.visibility = 'hidden'; 

		const imgSad = document.createElement("img"); 
		imgSad.id = "imgSad"; 
		imgSad.src = 'img/Sad128.png';
		imgSad.style.visibility = 'hidden'; 

		const imagesContainer = document.createElement("div");
		imagesContainer.appendChild(imgSmile);
		imagesContainer.appendChild(imgSad);

		this.container.appendChild(imagesContainer);
	}


	/**
	 * Called when any value in the property bag has changed. This includes field values, data-sets, global values such as container height and width, offline status, control metadata values such as label, visible, etc.
	 * @param context The entire property bag available to control via Context Object; It contains values as set up by the customizer mapped to names defined in the manifest, as well as utility functions
	 */
	public updateView(context: ComponentFramework.Context<IInputs>): void
	{
		Promise.resolve(this.xrmClient.countOpenTasks()).then(function(result){
			let smileVisibility = "visible"; 
			let sadVisibility = "hidden"; 

			if(result > 2){
				smileVisibility = "hidden"; 
				sadVisibility = "visible"; 
			}

			let smile = document.getElementById("imgSmile"); 
			if(smile){
				smile.style.visibility = smileVisibility; 
			}
			let sad = document.getElementById("imgSad"); 
			if(sad){
				sad.style.visibility = sadVisibility; 
			}
		}); 

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
}
