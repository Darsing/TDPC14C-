function insertAutore() {
    var body = {};
    body.NomeA = $('#nameAutore').val();
    $.ajax({
        method: "POST",
        url: "/api/Autore/InsertAutore",
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
};

function getAutore() {
    $.ajax({
        method: "GET",
        url: "/api/Autore/GetAutore",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data, status) {
            console.log(data);
            for (var i = 0; i < data.length; i++) {
                $("#resultAutore").append("<br/><div>" + " " + data[i].NomeA + "</div>");
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

function insertLibro() {
    var body = {};
    body.Nome = $('#nameLibro').val();
    body.NumeroPagine = $('#numeroLibro').val();
    body.NomeA = $('#nameAutore').val();
    $.ajax({
        method: "POST",
        url: "/api/Libro/InsertLibro",
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
};

function getLibro() {
    $.ajax({
        method: "GET",
        url: "/api/Libro/GetLibro",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data, status) {
            console.log(data);
            for (var i = 0; i < data.length; i++) {
                $("#resultLibro").append("<br/><div>" + " " + data[i].nome + " " + data[i].numeroPagine+ " "+data[i].nomeA+ "</div>");
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