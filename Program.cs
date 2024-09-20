using Learning.Examples;
using Learning.Excercises;

// --------------- Ejercicios -------------------
// var excercise1 = new Excercise1();
// var excercise2 = new Excercise2();
// var excercise3 = new Excercise3();
// var excersice4 = new Excercise4();
//var excercise5 = new Excercise5();
// var excercise6 = new Excercise6();

// --------------- Ejemplos ------------------
var example1 = new Example1();
example1.Print(12, "Hola");

var perro = new Perro("Pastor Aleman", "Cuadrupedo", "Pulmonar");
var gato = new Gato("Siames", "Cuadrupedo", "Pulmonar");
var any = new Any();

void PrintComerGenerico<T>(T value, string comida) where T : Specie
{
    value.Comer(comida);
}

PrintComerGenerico(perro, "Concentrado para perro");
PrintComerGenerico(gato, "Concentrado para gato");
// Como no hereda de Specie, no se puede usar el metodo Comer
// PrintComerGenerico(any, "Concentrado para cualquier animal");
