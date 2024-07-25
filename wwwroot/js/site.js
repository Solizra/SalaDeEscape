document.addEventListener('DOMContentLoaded', (event) => {
    const button = document.querySelector('.btn-pista');
    if (button) {
        const buttonId = button.getAttribute('id');
        button.addEventListener('click', function() {
            let message;
            switch(buttonId) {
                case 'habitacion1':
                    message = 'Para desifrar el número de pirámide numérica, observa atentamente cómo los números en cada fila interactúan entre sí. Cada número en un nivel superior es la suma de dos números directamente debajo de él. Comienza desde la base de la pirámide hacia la cima.';
                    break;
                case 'habitacion2':
                    message = 'Determina el valor de cada símbolo comenzando con los gansos en la primera fila, donde su suma es 30. Usa este valor para encontrar la figura humana en la segunda fila (total 18) y luego el tridente en la tercera fila (diferencia 1). Sustituye los valores en la ecuación final y divide entre 2 para encontrar el resultado. Tambien el tridente en la ecuación final solo tiene 2 palos, asi que su valor es diferente';
                    break;
                case 'habitacion3':
                    message = 'Para contar todos los triángulos, empieza identificando los más pequeños dentro de la figura. Luego, combina estos pequeños triángulos para formar triángulos más grandes. Recuerda que los triángulos pueden superponerse y compartirse líneas, así que verifica cada combinación posible. Asegúrate de incluir triángulos de diferentes tamaños y considera aquellos que abarcan varias secciones de la pirámide.';
                    break;
                case 'habitacion4':
                    message = 'Piensa que una vez que le restas 1 al 1111, el número sea 1110 (lo cual NO es 1111)';
                    break;
                default:
            }
            alert(message);
        });
    }
});