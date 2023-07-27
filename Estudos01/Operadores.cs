namespace Operadores
{
    class Operacao{

        private int numero1 = 10;
        private string text1 = "Maior ou Igual", text2 = "Menor ou Igual";

        public void OperadoresDeComparacao(){

            numero1 -= 10;
            numero1 += 10;
            numero1 *= 10;
            numero1 /= 10;
            numero1 += 10;

        }

        public string GetNumber(string text1, string text2){
            if(numero1 >= 20){
              return text1 = "Maior ou Igual";
            }else{
              return text2 = "Menor ou Igual";
            }

        }

    }
}