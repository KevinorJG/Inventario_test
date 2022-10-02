using Model.Entities;
using Model.Logs;
using Model.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Controller.Controller
{
    public class ProductController
    {
        protected List<Product> Products = new List<Product>();
        protected string Json;
        protected Predicate<Object> verify = (x) => x != null;
        protected Func<List<Product>, Product, bool> VerifyID = (a, b) => (a.First(z => z.Id != 0).Id == b.Id ? true : false);
        protected Product product = new Product();
        protected string ruta = Path.GetFullPath(Environment.CurrentDirectory) + @"\logs.txt";      
            
        public void Save(ProductViewModel model)
        {
            CreateLogs.Exceptions = null;
            try
            {

                if (verify(model) == false)
                {
                    throw new ArgumentNullException("El modelo está vacio");
                }

                Product product = new Product()
                {
                    Id = model.Id,
                    Name = model.Name,
                    Description = model.Description,
                    Category = model.Category,
                    Price = model.Price,
                    stock = model.stock,
                    Status = model.Status,
                };
                while (VerifyID(Products, product))
                {
                    product.Id = GenerarId();
                }
                Products.Add(product);


            }
            catch (Exception ex)
            {
                
                CreateLogs.Exceptions = ex;
                CreateLogs.Create(ex, MethodBase.GetCurrentMethod());
            }


        }

        public IEnumerable<Product> GetProducts()
        {
            return Products.AsQueryable().ToList();
        }

        public void SaveInfo(string ruta)
        {
            CreateLogs.Exceptions = null;
            try
            {
                File.Delete(ruta);
                using (StreamWriter writer = new StreamWriter(ruta, true))
                {
                    writer.BaseStream.Seek(0, SeekOrigin.End);
                    string registro = "";
                    foreach (var x in Products)
                    {
                        registro = ($"{x.Id},{x.Name},{x.Description},{x.stock},{x.Price},{x.Category},{x.Status},");
                        writer.WriteLine(registro);
                    }
                }
            }
            catch (Exception ex)
            {
                
                CreateLogs.Exceptions = ex;
                CreateLogs.Create(ex, MethodBase.GetCurrentMethod());
            }


        }
        public IEnumerable<Product> LoadProducts(string ruta)
        {
            CreateLogs.Exceptions = null;
            try
            {
              
                using (StreamReader lector = new StreamReader(ruta))
                {

                    string registro = lector.ReadLine();

                    int cont = 0;
                    while (registro != null)
                    {
                        int posFinal = registro.IndexOf(',');

                        string idproducto = registro.Substring(0, posFinal);
                        registro = registro.Substring(posFinal + 1);
                        posFinal = registro.IndexOf(',');

                        string nombreProducto = registro.Substring(0, posFinal);
                        registro = registro.Substring(posFinal + 1);
                        posFinal = registro.IndexOf(',');

                        string descripcion = registro.Substring(0, posFinal);
                        registro = registro.Substring(posFinal + 1);
                        posFinal = registro.IndexOf(',');

                        int existencia = Convert.ToInt32(registro.Substring(0, posFinal));
                        registro = registro.Substring(posFinal + 1);
                        posFinal = registro.IndexOf(',');

                        decimal precio = Convert.ToDecimal(registro.Substring(0, posFinal));
                        registro = registro.Substring(posFinal + 1);
                        posFinal = registro.IndexOf(',');

                        string categoria = registro.Substring(0, posFinal);
                        registro = registro.Substring(posFinal + 1);
                        posFinal = registro.IndexOf(',');

                        string estado = registro.Substring(0, posFinal);
                        registro = registro.Substring(posFinal + 1);
                        posFinal = registro.IndexOf(',');

                        cont++;
                        registro = lector.ReadLine();

                        product = new Product()
                        {
                            Id = int.Parse(idproducto),
                            Name = nombreProducto,
                            Description = descripcion,
                            stock = existencia,
                            Price = precio,
                            Category = categoria,
                            Status = estado,
                        };

                        Products.Add(product);
                    }
                    lector.Close();
                }

            }
            catch (Exception ex)
            {             
                CreateLogs.Exceptions = ex;
                CreateLogs.Create(ex,MethodBase.GetCurrentMethod());
            }

            return Products.AsQueryable().ToList();


        }
        public string[] Info(string ruta)
        {
            string[] file = new string[4];
            FileInfo fileInfo = new FileInfo(ruta);
            file[0] = fileInfo.Name.Replace(fileInfo.Extension, String.Empty);
            file[1] = fileInfo.Directory.Name;
            file[2] = $"{fileInfo.Length} bytes";
            file[3] = fileInfo.Extension;

            return file;
        }

        public bool Delete<T>(T model)
        {
            CreateLogs.Exceptions = null;
            try
            {
                PropertyInfo[] properties = typeof(T).GetProperties();
                var Id_model = Convert.ToInt32(properties.FirstOrDefault(x => x.Name == "Id").GetValue(model));
                int index = 0;
                foreach (var item in Products)
                {
                    if (item.Id == Id_model)
                    {
                        index = Products.IndexOf(item);
                        break;
                    }
                }

                if (Id_model != -1)
                {
                    Products.RemoveAt(index);
                    return true;
                }
            }
            catch (Exception ex)
            {
                CreateLogs.Exceptions = ex;
                CreateLogs.Create(ex, MethodBase.GetCurrentMethod());
            }
            return false;

        }
        public bool Update(ProductViewModel model, int index)
        {
            CreateLogs.Exceptions = null;
            try
            {
                if (verify(model))
                {
                    Product product = new Product()
                    {
                        Id = model.Id,
                        Name = model.Name,
                        Description = model.Description,
                        Category = model.Category,
                        Price = model.Price,
                        stock = model.stock,
                        Status = model.Status,
                    };

                    Products.RemoveAt(index);
                    Products.Insert(index, product);
                    CreateLogs.Exceptions = null;
                    return true;
                }
            }
            catch (Exception ex)
            {
                CreateLogs.Exceptions = ex;
                CreateLogs.Create(ex, MethodBase.GetCurrentMethod());
            }

            return false;

        }
       
        public int GenerarId()
        {

            var characters = "0123456789";
            var Charsarr = new char[4];
            var random = new Random();

            for (int i = 0; i < Charsarr.Length; i++)
            {
                Charsarr[i] = characters[random.Next(characters.Length)];
            }
            string charresult = new String(Charsarr);
            int idResult = Convert.ToInt32(charresult);
            return idResult;
        }
       
    }
}
