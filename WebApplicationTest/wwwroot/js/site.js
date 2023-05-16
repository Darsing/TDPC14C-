//questa è una funzione globale insertPerson()
//il body è la richiesta oppure il payload della riechiesta che ho mandato al backend
//qdo faccio la richiesta ho questo success ,error,always
//con success: function (data, status) è una funzione con 2 parametri
//invece data è oggetto che mi viene restituisce da server,è un payload
//invece status è la response della nostra richiesta in questo caso è success

//url: "/api/Person/InsertPerson",questo è endpoint (il controller si chiama Person e il nome è Post)
function insertPerson() {
    body.ID = "a3b5d487-0000-0000-0000-14d5c7813c8a";
    body.Nome = "Dante";
    body.Cognome = "Alighieri";
    $.ajax({
        method: "POST",
        url: "/api/Person/Post",
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify(body),
        dataType: "json",
        success: function (data, status) { 
            console.log(body);
            console.log(data);
            console.log(status);
            this.always();
        },
        error: function (error, status) {
            console.log(body);
            console.log(error);
            console.log(status);
            this.always();
        },
        always: function () { }
    });

    //funzione globale ajaxCallListaStringhe() che viene chiamata dentro la view/home/javascript.cshtml
    //Questo non ha il parametro data(body)
    //Lui sta chiamando un controller che si chiama Api e un endpoint che si chiama GetListaStringhe
    //(url: "/api/API/GetListaStringhe") ho cambiato il path(controller)
    //ha 2 callback success: e error:
    //success: logga la response del backend e fa un ciclo su quello che viene restituisto da backend
    function ajaxCallListaStringhe() {
        $.ajax({
            method: "GET",
            url: "/api/Person/GetListaStringhe",
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (data, status) {
                console.log(data);
                for (var i = 0; i < data.length; i++) {//questa è una collection
                    $("#resultDiv").append("<br/><div>" + data[i] + "</div>");
                }
                this.always();
            },
            error: function (error, status) {
                console.log(error);
                console.log(status);
                this.always();
            },
            always: function () { }
        });
    };

    //Passaggio di un dato prendendolo da un input
    //Qui viene messa un value che è =  $("#DDLValue").val() => significa che
    //Va a prendere elemento che si chiama con questo id e va a prendere il suo valore
    //Poi si compone url = "/api/API/GetDDLValue?id=" + value;
    //?id=" + value questa è una querry string (usarla se devi passare pochi parametri)
    //perchè non è sicura
    function ajaxCallDDLValue() {
        var value = $("#DDLValue").val();
        var url = "/api/Person/GetDDLValue?id=" + value;
        $.ajax({
            method: "GET",
            url: url,
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (data, status) {
                console.log(data);
                $("#resultDivDDLValue").append("<br/><div>" + data.value + "</div>");
                this.always();
            },
            error: function (error, status) {
                console.log(error);
                console.log(status);
                this.always();
            },
            always: function () { }
        });
};