
declare var Xrm: any;

export class XrmClient{
    
    constructor() {  }

    getUrl() : void{
        if((<any>Xrm) !== 'undefined'){
            var url: string = (<any>Xrm).Utility.getGlobalContext().getClientUrl();
            alert(url); 
        }
        else{
            alert("Xrm is not defined!"); 
        }     
    }
}