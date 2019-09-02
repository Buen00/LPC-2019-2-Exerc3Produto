    
using System.Collections.Generic;

namespace crudproduto.Models
{
    public class CarroRepository
    {
         public static List<Carro> carros = new List<Carro>();
    
        public CarroRepository()
        {           
        }

        public void Create(Carro carro)
        {
            carros.Add(carro);
        }
        public List<Carro> GetAll()
        {
            return carros;
        }
        
        public Carro GetByid(int id)
        {
            return carros.Find(x=>x.id == id);
        }
        
        public void Delete(int id)
        {
            carros.Remove(GetByid(id));

        }

        public void Update(Carro carro)
        {
            var index = carros.FindIndex(x=>x.id == carro.id);
            carros[index].fabricante = carro.fabricante;
            carros[index].categoria = carro.categoria;
            carros[index].modelo = carro.modelo;
            carros[index].ano_fab = carro.ano_fab;
            carros[index].tipo = carro.tipo;
        }

        
    }
    }