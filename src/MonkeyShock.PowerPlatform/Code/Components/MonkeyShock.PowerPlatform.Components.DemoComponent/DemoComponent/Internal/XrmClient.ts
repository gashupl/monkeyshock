
declare var Xrm: any;

export class XrmClient {

    constructor() { }

    getUrl(): void {
        if ((<any>Xrm) !== 'undefined') {
            var url: string = (<any>Xrm).Utility.getGlobalContext().getClientUrl();
            alert(url);
        }
        else {
            alert("Xrm is not defined!");
        }
    }

    createAccount(): void {

        let createdOn = Date.now();

        // define the data to create new account
        let data =
        {
            "name": "Sample Account created from PCF control " +  createdOn,
            "description": "This is the description of the sample account"
        }

        // create account record
        Xrm.WebApi.createRecord("account", data).then(
            function success(result: any) {
                alert("Account created with ID: " + result.id);
                // perform operations on record creation
            },
            function (error : any) {
                alert(error.message);
            }
        );
    }
}