function MostrarActores(idSerie){
    const cartel = document.querySelector("#MostrarInfo")
    cartel.style.display = "flex"
    $.ajax({
        url: '/Home/Actor',
        data: {idSerie: idSerie},
        type: 'GET',
        dataType: 'json',
        success: function(response) {
            let actores = ""
            response.forEach(element => {
                actores += "<p class='actores'>" + element.nombre + "</p>"
            })
            $("#MostrarInfo").html(`<h2>Actores</h2>
            <div class="listActores">${actores}</div>`)
        }, 
        error: function(xhr,status) {
            alert("Disculpe, existio un problema")
        },
        complete: function(xhr,status) {
            console.log("realizada")
        }
    })
}


function masInfo(idSerie){
    const cartel = document.querySelector("#MostrarInfo")
    cartel.style.display = "flex"
    $.ajax({
        url: '/Home/Descripcion',
        data: {idSerie: idSerie},
        type: 'GET',
        dataType: 'json',
        success: function(response) {
            $("#MostrarInfo").html(`<h2>Informacion de la serie</h2>
            <p>${response.sinopsis}</p>`)
        }, 
        error: function(xhr,status) {
            alert("Disculpe, existio un problema", xhr)
        },
        complete: function(xhr,status) {
            console.log("realizada")
        }
    })
}

function Temporadas(idSerie){
    const cartel = document.querySelector("#MostrarInfo")
    cartel.style.display = "flex"
    $.ajax({
        url: '/Home/Temporada',
        data: {idSerie: idSerie},
        type: 'GET',
        dataType: 'json',
        success: function(response) {
            console.log(response)
            let temporadas = ""
            response.forEach(element => {
                temporadas += "<p class='actores'>" + element.tituloTemporada + "</p>"
            })
            $("#MostrarInfo").html(`<h2>Temporadas</h2>
            <div class="listActores">${temporadas}</div>`)
        }, 
        error: function(xhr,status) {
            alert("Disculpe, existio un problema", xhr)
        },
        complete: function(xhr,status) {
            console.log("realizada")
        }
    })
}

function MostrarInfo(){
    const cartel = document.querySelector("#MostrarInfo")
    cartel.style.display = "flex"
    $.ajax({
        url: '/Home/Info',
        data: {},
        type: 'GET',
        dataType: 'json',
        success: function(response) {
            console.log(response)
            $("#MostrarInfo").html(`<h2>Informacion de la app</h2>
            <p>${response.informacion}</p>`)
        }, 
        error: function(xhr,status) {
            alert("Disculpe, existio un problema")
        },
        complete: function(xhr,status) {
            console.log("realizada")
        }
    })
}