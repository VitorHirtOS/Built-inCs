namespace Result
{
    class SampleClass
    {
        private string name = "José"; // Variável name é privada dentro da classe SampleClass

        public void SampleMethod()
        {
            name = "Vitor";
        }

        // Método público para retornar o valor da variável name
        public string Get()
        {
            return name;
        }
    }
}
