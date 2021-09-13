
declare var Xrm: any;

export class XrmClient {

    constructor() { }

    async countOpenTasks(){

        var activities : any = await Xrm.WebApi.retrieveMultipleRecords(
            "task", 
            "?$filter=_regardingobjectid_value eq f81a9b22-b6d5-eb11-bacc-000d3aaf68aa and statecode eq 0", 
            5); 
        return activities.entities.lenght; 
    }
}