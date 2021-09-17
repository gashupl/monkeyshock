
declare var Xrm: any;

export class XrmClient {

    constructor() { }

    countOpenTasks(resolve: any, reject: any){
        console.log("countOpenTasks..."); 
        return new Promise<any>((resolve, reject) => {
            Xrm.WebApi.retrieveMultipleRecords(
                "task", 
                "?$filter=_regardingobjectid_value eq f81a9b22-b6d5-eb11-bacc-000d3aaf68aa and statecode eq 0", 
                5).then(
                    function success(result: any){
                        console.log("success..."); 
                        if(result !== null && result !== undefined && result.entities !== null){
                            resolve(result.entities.lenght);
                        } 
                        else {
                            console.log("Missing results");
                            resolve(null);
                        }
                    },
                    function failed(error: any){
                        console.log(error);
                        reject();
                    }); 
            }
        );
    }
}