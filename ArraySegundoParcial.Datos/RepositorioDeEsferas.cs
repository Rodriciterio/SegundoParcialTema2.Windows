using ArraySegundoParcial.Entidades;

namespace ArraySegundoParcial.Datos
{
    public class RepositorioDeEsferas
    {
        private List<Esfera> listaEsferas;

        private readonly string _archivo = Environment.CurrentDirectory + "Esferas.txt";
        private readonly string _archivoCopia = Environment.CurrentDirectory + "Esferas.bak";

        public RepositorioDeEsferas()
        {
            listaEsferas = new List<Esfera>();
            LeerDatos();
        }

        private void LeerDatos()
        {
            if (!File.Exists(_archivo))
            {
                var lector = new StreamReader(_archivo);
                while (!lector.EndOfStream)
                {
                    string lineaLeida = lector.ReadLine();
                    Esfera esfera = ConstruirEsfera(lineaLeida);
                    listaEsferas.Add(esfera);
                }
                lector.Close();
            }
        }

        private Esfera ConstruirEsfera(string? lineaLeida)
        {
            var campos = lineaLeida.Split('|');
            var radio = int.Parse(campos[0]);
            TipoDeBorde borde = (TipoDeBorde)int.Parse(campos[1]);
            TipoDeRelleno relleno = (TipoDeRelleno)int.Parse(campos[2]);
            Esfera e = new Esfera(radio, borde, relleno);
            return e;
        }

        public void Agregar(Esfera esfera)
        {
            var escritor = new StreamWriter(_archivo, true);
            string lineaEscribir = ConstruirLinea(esfera);
            escritor.WriteLine(lineaEscribir);
            escritor.Close();
            listaEsferas.Add(esfera);
        }

        private string ConstruirLinea(Esfera esfera)
        {
            return $"{esfera.Radio} | {esfera.TipoDeBorde.GetHashCode()} | {esfera.TipoDeRelleno.GetHashCode()}";
        }

        public bool Existe(Esfera esfera)
        {
            listaEsferas.Clear();
            LeerDatos();
            foreach (var itemEsfera in listaEsferas)
            {
                if (itemEsfera.Radio == esfera.Radio && itemEsfera.TipoDeBorde == esfera.TipoDeBorde &&
                    itemEsfera.TipoDeRelleno == esfera.TipoDeRelleno)
                {
                    return true;
                }
            }
            return false;
        }

        public int GetCantidad(int valorFiltro = 0)
        {
            if (valorFiltro>0)
            {
                return listaEsferas.Count(e => e.Radio >= valorFiltro);
            }
            return listaEsferas.Count;
        }

        public void Borrar(Esfera esferaBorrar)
        {
            using (var lector = new StreamReader(_archivo))
            {
                using (var escritor = new StreamWriter(_archivoCopia))
                {
                    while (!lector.EndOfStream)
                    {
                        string lineaLeida = lector.ReadLine();
                        Esfera esferaLeida = ConstruirEsfera(lineaLeida);
                        if (esferaBorrar.Radio != esferaLeida.Radio)
                        {
                            escritor.WriteLine(lineaLeida);
                        }
                    }
                }
            }
            File.Delete(_archivo);
            File.Move(_archivoCopia, _archivo);
            listaEsferas.Remove(esferaBorrar);
        }

        public void Editar(Esfera esferaEnArchivo, Esfera esferaEditar)
        {
            using (var lector = new StreamReader(_archivo))
            {
                using (var escritor = new StreamWriter(_archivoCopia))
                {
                    while (!lector.EndOfStream)
                    {
                        string lineaLeida = lector.ReadLine();
                        Esfera esfera = ConstruirEsfera(lineaLeida);
                        if (esferaEnArchivo.Radio != esfera.Radio)
                        {
                            escritor.WriteLine(lineaLeida);
                        }
                        else
                        {
                            lineaLeida = ConstruirLinea(esferaEditar);
                            escritor.WriteLine(lineaLeida);
                        }
                    }
                }
            }
            File.Delete(_archivo);
            File.Move(_archivoCopia, _archivo);
        }

        public List<Esfera> Filtrar(int intValor)
        {
           return listaEsferas.Where(e=>e.Radio>= intValor).ToList();
        }

        public List<Esfera> GetLista()
        {
            return listaEsferas;
        }

        public List<Esfera> OrdenarAsc()
        {
            return listaEsferas.OrderBy(e=>e.Radio).ToList();
        }

        public List<Esfera> OrdenarDesc()
        {
            return listaEsferas.OrderByDescending(e => e.Radio).ToList();
        }
    }
}