namespace crudproduto.Models
{
    public class Carro
    {
        public Carro(){}

        public Carro(int id, string fabricante, string categoria, string modelo, int ano_fab, string tipo)
        {
            this.id = id;
            this.fabricante = fabricante;
            this.categoria= categoria;
            this.modelo = modelo;
            this.ano_fab = ano_fab;
            this.tipo = tipo;
        }
        public int id {get; set;}
        public string fabricante { get; set; }
        public string categoria { get; set; }
        public string modelo { get; set; }
        public int ano_fab { get; set; }      
        public string tipo { get; set; }  

    }    
}
