// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

const Pista1=document.querySelector(".Pista1");
const Pista2=document.querySelector(".Pista2");
const Pista3=document.querySelector(".Pista3");
const Pista4=document.querySelector(".Pista4");


Pista1.addEventListener("click",(e)=>{
    alert("Para desifrar el número de pirámide numérica, observa atentamente cómo los números en cada fila interactúan entre sí. Cada número en un nivel superior es la suma de dos números directamente debajo de él. Comienza desde la base de la pirámide hacia la cima.")
})
Pista2.addEventListener("click",(e)=>{
    alert("Determina el valor de cada símbolo comenzando con los gansos en la primera fila, donde su suma es 30. Usa este valor para encontrar la figura humana en la segunda fila (total 18) y luego el tridente en la tercera fila (diferencia 1). Sustituye los valores en la ecuación final y divide entre 2 para encontrar el resultado.")
})
Pista3.addEventListener("click",(e)=>{
    alert("Para contar todos los triángulos, empieza identificando los más pequeños dentro de la figura. Luego, combina estos pequeños triángulos para formar triángulos más grandes. Recuerda que los triángulos pueden superponerse y compartirse líneas, así que verifica cada combinación posible. Asegúrate de incluir triángulos de diferentes tamaños y considera aquellos que abarcan varias secciones de la pirámide.")
})
Pista4.addEventListener("click",(e)=>{
    alert("")
})