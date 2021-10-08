
declare var Xrm: any;

export class XrmClient {

    constructor() { }

    countOpenTasks(){
        return new Promise<any>(() => {
            Xrm.WebApi.retrieveMultipleRecords(
                "task", 
                "?$filter=_regardingobjectid_value eq f81a9b22-b6d5-eb11-bacc-000d3aaf68aa and statecode eq 0", 
                5).then(
                    function success(result: any){
                        console.log("success..."); 
                        if(result !== null && result !== undefined && result.entities !== null){
                            console.log("result exits");
                            console.log(result.entities.length); 
                            let smileVisibility = "visible"; 
                            let sadVisibility = "hidden"; 
            
                            if(result.entities.length > 2){
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
                        } 
                        else {
                            console.log("Missing results");
                        }
                    },
                    function failed(error: any){
                        console.log(error);
                    }); 
            }
        );
    }
}