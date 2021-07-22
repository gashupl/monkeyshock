export class ButtonFactory{

    getButton(label: string, clickHandler: any) : HTMLButtonElement{
        const btn = document.createElement("button");
		btn.textContent = label; 
		btn.addEventListener("click", clickHandler);
        return btn; 
    }
}
    