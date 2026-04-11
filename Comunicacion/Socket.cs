using DocumentFormat.OpenXml.Bibliography;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Sockets;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Comunicacion
{
    public class Infocliente
    {

        public TcpClient Conexion { get; set; }

        public string Nombre { get; set; }

        public Infocliente(TcpClient conexion, string nombre)
        {
            Conexion = conexion;
            Nombre = nombre;
        }
    }

    public class ServidorSocket
    {
        private const string IP_SERVIDOR = "127.0.0.1";
        private const int PUERTO_SERVIDOR = 15500;

        private const int MAX_CLIENTES = 5;
        private TcpListener? servidor; //puede ser nulo, se le pone ?
        private Thread hiloEscucha;

        private bool servidorActivo = false;
        private List<Infocliente> clientesConectados;
        public event Action<string>? NuevaBitacora;
        public event Action<string>? ClienteDesconectado;
        public event Action<string>? ClienteConectado;

        public ServidorSocket()
        {
            clientesConectados = new List<Infocliente>();
        }
       /* public void Iniciar()
        {
            try
            {
                servidor = new TcpListener(IPAddress.Parse(IP_SERVIDOR), PUERTO_SERVIDOR);
                servidor.Start();
                servidorActivo = true;
                NuevaBitacora?.Invoke($"Servidor iniciado en {IP_SERVIDOR}:{PUERTO_SERVIDOR}");
                NuevaBitacora?.Invoke($"Maximo clientes: {MAX_CLIENTES}");

                hiloEscucha = new Thread(EscucharConexiones);
                hiloEscucha.IsBackground = true;
                hiloEscucha.Start();

            }
            catch (Exception ex)
            {
                NuevaBitacora?.Invoke($"Error al iniciar el servidor: {ex.Message}intente más tarde");
            }
        }
        public void EscucharConexiones()
        {
            try
            {
                while (servidorActivo)
                {
                    TcpClient cliente = servidor!.AcceptTcpClient();
                    if (clientesConectados.Count >= MAX_CLIENTES)
                    {
                        NuevaBitacora?.Invoke($"Conexión rechazada: {MAX_CLIENTES} intente más tarde");
                        cliente.Close();
                        continue; //break
                    }
                    Thread hiloCliente = new Thread(() => AtenderCliente(cliente));
                    hiloCliente.IsBackground = true;
                    hiloCliente.Start();
                }


            }
            catch (Exception ex)
            {
                NuevaBitacora?.Invoke($"Error al escuchar conexiones: {ex.Message}");
                Console.WriteLine(ex.ToString());
            }
        }
        public void AtenderCliente(TcpClient cliente)
        {
            NetworkStream? streams = null;
            string nombreCliente = "Desconocido";
            Infocliente? infoCliente = null;

            try
            {
                //Obtener el stream de comunicacion
                streams = cliente.GetStream();

                using (StreamReader reader = new StreamReader(streams, Encoding.UTF8, leaveOpen: true))
                using (StreamWriter writer = new StreamWriter(streams, Encoding.UTF8, leaveOpen: true))
                {
                    //Paso 1: recibir el nombre de cliente
                    string? mensajeBienvenidaJson = reader.ReadLine();
                    if (!string.IsNullOrEmpty(mensajeBienvenidaJson))
                    {
                        Mensaje? mensajeBienvenida = JsonConverter.DeserializeObject<Mensaje>(mensajeBienvenidaJson);

                        if (mensajeBienvenida != null && mensajeBienvenida.Accion == "CONECTAR")
                        {
                            nombreCliente = mensajeBienvenida.Datos;
                            //Crear infocliente y agregarlo a la lista de clientes conectados
                            infoCliente = new Infocliente(cliente, nombreCliente);
                            clientesConectados.Add(infoCliente);
                            //Notificar a la UI
                            NuevaBitacora?.Invoke($"Cliente conectado: {nombreCliente} ({cliente.Client.RemoteEndPoint})");
                            ClienteConectado?.Invoke(nombreCliente);
                            //Enviar configuracion al cliente
                            Mensaje respuestaBienvenida = new Mensaje("OK", "Conexion", "$Bienvenido {nombreCliente}");
                            string respuestaJson = JsonConverter.SerializeObject(respuestaBienvenida);
                            writer.WriteLine(respuestaJson);
                            writer.Flush();
                        }
                    }
                }//PAso 2: ciclo de peticiones normales
                while (cliente.Connected && servidorActivo)
                {
                    string? mensajeJson = Reader.ReadLine();
                    if (string.IsNullOrEmpty(mensajeJson))

                        break;
                    NuevaBitacora?.Invoke($"[{nombreCliente}] Mensaje recibido");
                    Mensaje? mensaje = JsonConverter.DeserializeObject<Mensaje>(mensajeJson);
                    if (mensaje != null)
                    {
                        Mensaje respuesta = ProcesarMensaje(mensaje);
                        string respuestaJson = JsonConverter.SerializeObject(respuesta);
                        Writer.WriteLine(respuestaJson);
                        Writer.Flush();
                        NuevaBitacora?.Invoke($"[{nombreCliente}] Respuesta enviada {respuesta.Accion}");
                    }

                }

            }
            catch (Exception ex)
            {
                NuevaBitacora?.Invoke($"[{nombreCliente}] Error: {ex.Message}");
            }
            finally
            {    //remover de la lista y cerrar
                if (infoCliente != null)
                {
                    clientesConectados.Remove(infoCliente);

                }
                cliente.Close();
                NuevaBitacora?.Invoke($"Cliente: {nombreCliente}' desconectado . Total:({clientesConectados.Count}/{MAX_CLIENTES})");
                ClienteDesconectado?.Invoke(nombreCliente);
            }
        }
        private Mensaje ProcesarMensaje(Mensaje mensaje)
        {
            Mensaje respuesta = new Mensaje();
            try
            {
                swith(mensaje.Tipo)

            } catch (Exception ex) {
            }
        }*/
    } 
}




 
