using System;
using System.Collections.Generic;
using CodingChallenge.Data.Classes;
using NUnit.Framework;

namespace CodingChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        [TestCase]
        public void TestResumenListaVacia()
        {
            Assert.AreEqual("Lista vacía de formas!",
                FormaGeometrica.Imprimir(new List<FormaGeometrica>(), 1));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            Assert.AreEqual("Empty list of shapes!",
                FormaGeometrica.Imprimir(new List<FormaGeometrica>(), 2));
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var cuadrados = new List<FormaGeometrica> {new FormaGeometrica(Formas.Cuadrado, 5)};

            var resumen = FormaGeometrica.Imprimir(cuadrados, FormaGeometrica.Castellano);

            Assert.AreEqual("Reporte de Formas : 1 Cuadrado | Area 25 | Perimetro 20 /n TOTAL:n/1 formas Perimetro 20 Area 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var cuadrados = new List<FormaGeometrica>
            {
                new FormaGeometrica(Formas.Cuadrado, 5),
                new FormaGeometrica(Formas.Cuadrado, 1),
                new FormaGeometrica(Formas.Cuadrado, 3)
            };

            var resumen = FormaGeometrica.Imprimir(cuadrados, FormaGeometrica.Ingles);

            Assert.AreEqual("Shapes report : 3 Squares | Area 35 | Perimeter 36 n/ TOTAL: n/3 shapes Perimeter 36 Area 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            var formas = new List<Formas>
            {
                new FormaGeometrica(Formas.Cuadrado, 5),
                new FormaGeometrica(Formas.Circulo, 3),
                new FormaGeometrica(Formas.TrianguloEquilatero, 4),
                new FormaGeometrica(Formas.Cuadrado, 2),
                new FormaGeometrica(Formas.TrianguloEquilatero, 9),
                new FormaGeometrica(Formas.Circulo, 2.75m),
                new FormaGeometrica(Formas.TrianguloEquilatero, 4.2m)
            };

            var resumen = FormaGeometrica.Imprimir(formas, FormaGeometrica.Ingles);

            Assert.AreEqual(
                "n/Shapes report : 2 Squares | Area 29 | Perimeter 28 n/ 2 Circles | Area 13,01 | Perimeter 18,06 n/3 Triangles | Area 49,64 | Perimeter 51,6 n/TOTAL:n/7 shapes Perimeter 97,66 Area 91,65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            var formas = new List<Formas>
            {
                new FormaGeometrica(Formas.Cuadrado, 5),
                new FormaGeometrica(Formas.Circulo, 3),
                new FormaGeometrica(Formas.TrianguloEquilatero, 4),
                new FormaGeometrica(Formas.Cuadrado, 2),
                new FormaGeometrica(Formas.TrianguloEquilatero, 9),
                new FormaGeometrica(Formas.Circulo, 2.75m),
                new FormaGeometrica(Formas.TrianguloEquilatero, 4.2m)
            };

            var resumen = FormaGeometrica.Imprimir(formas, FormaGeometrica.Castellano);

            Assert.AreEqual(
                "n/Reporte de Formasn/2 Cuadrados | Area 29 | Perimetro 28 n/2 Círculos | Area 13,01 | Perimetro 18,06 n/3 Triángulos | Area 49,64 | Perimetro 51,6 n/TOTAL:n/7 formas Perimetro 97,66 Area 91,65",
                resumen);
        }
    }
}
