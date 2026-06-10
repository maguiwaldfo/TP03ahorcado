const inputLetra = document.getElementById("letra");
const inputPalabra = document.getElementById("palabra");
const divPalabraOculta = document.getElementById("palabraOculta");
const divChances = document.getElementById("ChancesRestantes");
const divMensaje = document.getElementById("mensaje");

let palabra = inputPalabra.value.toLowerCase();
let chancesRestantes = 10;
let palabraOculta = "";
let letrasArriesgadas = "";

for (let i = 0; i < palabra.length; i++) {
    palabraOculta += "_";
}

divPalabraOculta.innerHTML = palabraOculta;
divChances.innerHTML = "Intentos restantes: " + chancesRestantes;
divMensaje.innerHTML = "";

function ArriesgarLetra() {

    if (chancesRestantes <= 0 || !palabraOculta.includes("_")) {
        return;
    }

    const letra = inputLetra.value.toLowerCase();
    inputLetra.value = "";

    if (letra === "") {
        divMensaje.innerHTML = "Por favor, ingresá una letra.";
        divMensaje.style.color = "orange";
        return;
    }

    if (letrasArriesgadas.includes(letra)) {
        divMensaje.innerHTML = "Ya arriesgaste la letra '" + letra + "'";
        divMensaje.style.color = "orange";
        return;
    }

    letrasArriesgadas += letra;

    if (palabra.includes(letra)) {

        let nuevaPalabraOculta = "";

        for (let i = 0; i < palabra.length; i++) {

            if (palabra[i] === letra) {
                nuevaPalabraOculta += letra;
            }
            else {
                nuevaPalabraOculta += palabraOculta[i];
            }
        }

        palabraOculta = nuevaPalabraOculta;

        divMensaje.innerHTML = "¡Acertaste! La letra '" + letra + "' es correcta.";
        divMensaje.style.color = "green";
    }
    else {

        chancesRestantes--;

        divMensaje.innerHTML = "La letra '" + letra + "' no está en la palabra.";
        divMensaje.style.color = "red";
    }

    divPalabraOculta.innerHTML = palabraOculta;
    divChances.innerHTML = "Intentos restantes: " + chancesRestantes;

    if (!palabraOculta.includes("_")) {

        divMensaje.innerHTML = "<strong>¡Felicidades! Ganaste el juego</strong>";
        divMensaje.style.color = "green";
    }
    else if (chancesRestantes <= 0) {

        divMensaje.innerHTML = "<strong>¡Te quedaste sin intentos! La palabra era: " + palabra + "</strong>";
        divMensaje.style.color = "red";
    }
}