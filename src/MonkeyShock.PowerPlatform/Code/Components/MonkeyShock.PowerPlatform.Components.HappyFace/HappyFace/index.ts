import {IInputs, IOutputs} from "./generated/ManifestTypes";
import { XrmClient } from "./xrmClient";

const smileImagePath : string = "./img/Smile128.png";
const sadImagePath : string = "./img/Sad128.png";

export class HappyFace implements ComponentFramework.StandardControl<IInputs, IOutputs> {

	private context: ComponentFramework.Context<IInputs>;
	private container: HTMLDivElement;
	private notifyOutputChanged: () => void;
	private xrmClient : XrmClient; 

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
		this.container = container;
		this.notifyOutputChanged = notifyOutputChanged;
		//this.xrmClient = new XrmClient(); 

		//According to: https://powerusers.microsoft.com/t5/Power-Apps-Pro-Dev-ISV/Is-there-an-example-of-using-Image-Resources-within-PCF-control/td-p/342152

		this.smileImgElement = document.createElement("img");	
		this.smileImgElement.id = "imgSmile"; 
		//this.smileImgElement.style.visibility = 'hidden'; 
		this.context.resources.getResource("Smile128.png", this.setSmileImage.bind(this, false, "png"), this.showError.bind(this));
		
		this.sadImgElement = document.createElement("img"); 
		this.sadImgElement .id = "imgSad"; 
		//this.sadImgElement.style.visibility = 'hidden'; 
		this.context.resources.getResource("Sad128.png", this.setSadImage.bind(this, false, "png"), this.showError.bind(this));

		const imagesContainer = document.createElement("div");
		imagesContainer.appendChild(this.smileImgElement);
		imagesContainer.appendChild(this.sadImgElement);

		this.container.appendChild(imagesContainer);
	}


	/**
	 * Called when any value in the property bag has changed. This includes field values, data-sets, global values such as container height and width, offline status, control metadata values such as label, visible, etc.
	 * @param context The entire property bag available to control via Context Object; It contains values as set up by the customizer mapped to names defined in the manifest, as well as utility functions
	 */
	public updateView(context: ComponentFramework.Context<IInputs>): void
	{
		return; 
		let smileVisibility = "visible"; 
		let sadVisibility = "hidden"; 

		this.smileImgElement.style.visibility = smileVisibility; 
		this.sadImgElement.style.visibility = sadVisibility; 

		this.xrmClient.countOpenTasks(
			function(result: any){
				console.log("result exits");
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
			}, 
			function(result: any){}); 

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

	private setSmileImage(shouldUpdateOutput: boolean, fileType: string, fileContent: string): void
	{
		console.log("setSmileImage");
		let imageUrl: string = this.generateImageSrcUrl(fileType, fileContent);
		this.smileImgElement.src = imageUrl;
		console.log("setSmileImage: " + this.smileImgElement.src); 

	}

	private setSadImage(shouldUpdateOutput: boolean, fileType: string, fileContent: string): void
	{
		console.log("setSadImage");
		let imageUrl: string = this.generateImageSrcUrl(fileType, fileContent);
		this.sadImgElement.src = imageUrl;
		console.log("setSadImage: " + this.sadImgElement.src); 

	}

	private generateImageSrcUrl(fileType: string, fileContent: string): string
	{
		return  "data&colon;image/" + fileType + ";base64," + fileContent;
	}
	
	private showError(): void
	{

	}
}
