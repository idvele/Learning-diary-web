// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function Helper()
{
    window.alert("pls send help")
}

function colorOn(id) {

    document.getElementById(id).style.backgroundColor = 'red';
}

function colorOff(id){

    document.getElementById(id).style.backgroundColor = 'cadetblue';
}

function colorOnC(Class) {
    document.getElementByClass(Class).style.backgroundColor = 'red';
}

//function red(object) {
//    object.style.background = 'red'
//}

//function white(object) {
//    object.style.background = 'white'
//}

$(document).ready(function () {
    $('.form-control').bind("mouseover", function () {
        var color = $(this).css("background-color");

        $(this).css("background", "#F9C3F3");

        $(this).bind("mouseout", function () {
            $(this).css("background", color);
        })
    })
})

$(document).ready(function () {
    $('.JokeBtn').bind("click", function () {  //tähän targetti
        var jokeApi = "https://v2.jokeapi.dev/joke/Any?blacklistFlags=nsfw,racist,sexist";

        $.getJSON(jokeApi, function (data) {
            console.log(data.joke)
            console.log(data.setup)
            console.log(data.delivery)

           
            if (data.joke != undefined) {
                document.getElementById('jokePrint').innerHTML =
                    data.joke

            }
            else {
            
                function Delivery(del) {
                    document.getElementById('jokePrint').innerHTML =
                        data.setup + "<br/>" + data.delivery
                }
                setTimeout(Delivery, 4000);
                document.getElementById('jokePrint').innerHTML =
                    data.setup;

                
            }

        })
    })
})

//Aloita aina alla olevalla perus JQuery -käskyllä JA lisää toiminnot funktion { } sisään.
//JQuery käskyissä AINA ensin valinta (mihin targetoidaan) ja sitten JQuery event (mitä sille tehdään)
$(document).ready(function () {
    $("#test").click(function () {
        $("#test-message").toggle();
    });
});

