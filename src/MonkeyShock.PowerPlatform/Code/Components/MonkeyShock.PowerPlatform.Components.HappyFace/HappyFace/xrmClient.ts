
declare var Xrm: any;

export class XrmClient {

    constructor() { }

    countOpenTasks(entityId: string, smileImagePath: string, sadImagePath: string){
        return new Promise<any>(() => {
            Xrm.WebApi.retrieveMultipleRecords(
                "task", 
                //"?$filter=_regardingobjectid_value eq f81a9b22-b6d5-eb11-bacc-000d3aaf68aa and statecode eq 0", 
                "?$filter=_regardingobjectid_value eq " + entityId + " and statecode eq 0", 
                5).then(
                    function success(result: any){
                        console.log("success..."); 
                        if(result !== null && result !== undefined && result.entities !== null){

                            let smile = document.getElementById("imgSmile")as HTMLImageElement; 
                            if(result.entities.length > 2){
                                smile.src = sadImagePath; 
                            }
                            else{
                                smile.src = smileImagePath; 
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