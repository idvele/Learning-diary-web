// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function Helper()
{
    window.alert("tämä toimii!")
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

function red(object) {
    object.style.background = 'red'
}

function white(object) {
    object.style.background = 'white'
}
