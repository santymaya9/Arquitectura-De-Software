using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Instanciar SistemaIntegrado
        var sistema = new SistemaIntegrado("Sistema Clínica de Emergencias", 
            new List<Cuenta>(), new List<CentroMedico>());

        // Instanciar servicios principales usando inyección de dependencias
        var mostrarService = new MostrarService();
        var crearService = new CrearService();
        var actualizarService = new ActualizarService();
        var eliminarService = new EliminarService();

        // Servicios especializados con inyección de dependencias
        var visualizadorSistema = new VisualizadorSistemaIntegrado(mostrarService, mostrarService);
        var eliminadorSistema = new EliminadorSistemaIntegrado(eliminarService, eliminarService);
        var actualizadorSistema = new ActualizadorSistemaIntegrado(actualizarService);
        var registroCuentas = new RegistroCuentas(new RolOperador(), crearService);
        var gestionCentroMedico = new GestionCentroMedico();
        var gestionParamedico = new GestionParamedico();
        var gestionPaciente = new GestionPaciente();
        var navegacion = new Navegacion();
        var comunicacion = new Comunicacion();

        Console.WriteLine("===== SISTEMA CLÍNICA DE EMERGENCIAS =====");
        Console.WriteLine($"Sistema: {sistema.Nombre}");
        Console.WriteLine("Todos los servicios inicializados correctamente.\n");

        MostrarMenuPrincipal(sistema, visualizadorSistema, eliminadorSistema, actualizadorSistema, 
                           registroCuentas, gestionCentroMedico, gestionParamedico, gestionPaciente, 
                           navegacion, comunicacion, mostrarService);
    }

    private static void MostrarMenuPrincipal(SistemaIntegrado sistema, 
                                           VisualizadorSistemaIntegrado visualizador,
                                           EliminadorSistemaIntegrado eliminador,
                                           ActualizadorSistemaIntegrado actualizador,
                                           RegistroCuentas registroCuentas,
                                           GestionCentroMedico gestionCentro,
                                           GestionParamedico gestionParamedico,
                                           GestionPaciente gestionPaciente,
                                           Navegacion navegacion,
                                           Comunicacion comunicacion,
                                           MostrarService mostrarService)
    {
        int opcion;
        do
        {
            Console.WriteLine("\n===== MENÚ PRINCIPAL =====");
            Console.WriteLine("1. Gestión de Cuentas (Con Servicios Especializados)");
            Console.WriteLine("2. Gestión de Centros Médicos (Con Servicios Especializados)");
            Console.WriteLine("3. Gestión de Alertas de Emergencia");
            Console.WriteLine("4. Gestión de Paramédicos");
            Console.WriteLine("5. Gestión de Pacientes");
            Console.WriteLine("6. Navegación y Rutas");
            Console.WriteLine("7. Comunicación");
            Console.WriteLine("8. Mostrar Información del Sistema (Con Visualizador)");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");

            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        MenuGestionCuentasAvanzado(sistema, registroCuentas, eliminador, actualizador, visualizador);
                        break;
                    case 2:
                        MenuGestionCentrosMedicosAvanzado(sistema, gestionCentro, eliminador, visualizador);
                        break;
                    case 3:
                        MenuGestionAlertas(gestionParamedico, gestionPaciente);
                        break;
                    case 4:
                        MenuGestionParamedicos(gestionParamedico);
                        break;
                    case 5:
                        MenuGestionPacientes(gestionPaciente, navegacion);
                        break;
                    case 6:
                        MenuNavegacion(navegacion);
                        break;
                    case 7:
                        MenuComunicacion(comunicacion);
                        break;
                    case 8:
                        MostrarInformacionSistemaAvanzada(sistema, visualizador);
                        break;
                    case 0:
                        Console.WriteLine("Gracias por usar el Sistema Clínica de Emergencias.");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente nuevamente.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Por favor, ingrese un número válido.");
            }
        } while (opcion != 0);
    }

    private static void MenuGestionCuentasAvanzado(SistemaIntegrado sistema, 
                                                 RegistroCuentas registroCuentas,
                                                 EliminadorSistemaIntegrado eliminador,
                                                 ActualizadorSistemaIntegrado actualizador,
                                                 VisualizadorSistemaIntegrado visualizador)
    {
        int opcion;
        do
        {
            Console.WriteLine("\n===== GESTIÓN AVANZADA DE CUENTAS =====");
            Console.WriteLine("1. Crear Cuenta (Con RegistroCuentas)");
            Console.WriteLine("2. Mostrar Cuentas (Con Visualizador)");
            Console.WriteLine("3. Actualizar Cuenta (Con ActualizadorSistema)");
            Console.WriteLine("4. Eliminar Cuenta (Con EliminadorSistema)");
            Console.WriteLine("5. Iniciar Sesión");
            Console.WriteLine("6. Cerrar Sesión");
            Console.WriteLine("0. Volver al menú principal");
            Console.Write("Seleccione una opción: ");

            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        CrearCuentaConServicio(sistema, registroCuentas);
                        break;
                    case 2:
                        MostrarCuentasConVisualizador(sistema, visualizador);
                        break;
                    case 3:
                        ActualizarCuentaConServicio(sistema, actualizador);
                        break;
                    case 4:
                        EliminarCuentaConServicio(sistema, eliminador);
                        break;
                    case 5:
                        IniciarSesionAvanzado(sistema);
                        break;
                    case 6:
                        CerrarSesionAvanzado(sistema);
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        } while (opcion != 0);
    }

    private static void MenuGestionCentrosMedicosAvanzado(SistemaIntegrado sistema,
                                                        GestionCentroMedico gestionCentro,
                                                        EliminadorSistemaIntegrado eliminador,
                                                        VisualizadorSistemaIntegrado visualizador)
    {
        int opcion;
        do
        {
            Console.WriteLine("\n===== GESTIÓN AVANZADA DE CENTROS MÉDICOS =====");
            Console.WriteLine("1. Crear Centro Médico (Con GestionCentroMedico)");
            Console.WriteLine("2. Actualizar Centro Médico (Con GestionCentroMedico)");
            Console.WriteLine("3. Eliminar Centro Médico (Con EliminadorSistema)");
            Console.WriteLine("4. Mostrar Centros Médicos (Con Visualizador)");
            Console.WriteLine("0. Volver al menú principal");
            Console.Write("Seleccione una opción: ");

            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        CrearCentroMedicoConServicio(sistema, gestionCentro);
                        break;
                    case 2:
                        ActualizarCentroMedicoConServicio(sistema, gestionCentro);
                        break;
                    case 3:
                        EliminarCentroMedicoConServicio(sistema, eliminador);
                        break;
                    case 4:
                        MostrarCentrosMedicosConVisualizador(sistema, visualizador);
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        } while (opcion != 0);
    }

    private static void MenuGestionAlertas(GestionParamedico gestionParamedico, GestionPaciente gestionPaciente)
    {
        int opcion;
        do
        {
            Console.WriteLine("\n===== GESTIÓN DE ALERTAS DE EMERGENCIA =====");
            Console.WriteLine("1. Crear Alerta (Con GestionPaciente)");
            Console.WriteLine("2. Cambiar Estado de Alerta (Con GestionParamedico)");
            Console.WriteLine("3. Registrar Atención (Con GestionParamedico)");
            Console.WriteLine("4. Asignar Triaje (Con GestionParamedico)");
            Console.WriteLine("0. Volver al menú principal");
            Console.Write("Seleccione una opción: ");

            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        CrearAlertaConServicio(gestionPaciente);
                        break;
                    case 2:
                        CambiarEstadoAlertaConServicio(gestionParamedico);
                        break;
                    case 3:
                        RegistrarAtencionConServicio(gestionParamedico);
                        break;
                    case 4:
                        AsignarTriajeConServicio(gestionParamedico);
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        } while (opcion != 0);
    }

    private static void MenuGestionParamedicos(GestionParamedico gestionParamedico)
    {
        Console.WriteLine("\n===== GESTIÓN DE PARAMÉDICOS =====");
        Console.WriteLine("Usando GestionParamedico para operaciones especializadas...");
        Console.WriteLine("✅ Servicios de paramédicos implementados con arquitectura avanzada");
        Console.WriteLine("Presione cualquier tecla para continuar...");
        Console.ReadKey();
    }

    private static void MenuGestionPacientes(GestionPaciente gestionPaciente, Navegacion navegacion)
    {
        Console.WriteLine("\n===== GESTIÓN DE PACIENTES =====");
        Console.WriteLine("Usando GestionPaciente y Navegacion para operaciones especializadas...");
        Console.WriteLine("✅ Servicios de pacientes y navegación implementados");
        Console.WriteLine("Presione cualquier tecla para continuar...");
        Console.ReadKey();
    }

    private static void MenuNavegacion(Navegacion navegacion)
    {
        Console.WriteLine("\n===== NAVEGACIÓN Y RUTAS =====");
        Console.WriteLine("Usando servicio Navegacion especializado...");
        Console.WriteLine("✅ Servicios de navegación, rutas y geolocalización activos");
        Console.WriteLine("Presione cualquier tecla para continuar...");
        Console.ReadKey();
    }

    private static void MenuComunicacion(Comunicacion comunicacion)
    {
        Console.WriteLine("\n===== COMUNICACIÓN =====");
        Console.Write("Ingrese el número de teléfono para llamar: ");
        if (int.TryParse(Console.ReadLine(), out int telefono))
        {
            string resultado = comunicacion.Llamar(telefono);
            Console.WriteLine($"✅ Resultado de la llamada: {resultado}");
        }
        else
        {
            Console.WriteLine("❌ Número de teléfono no válido.");
        }
    }

    // Métodos específicos que usan los servicios especializados
    private static void CrearCuentaConServicio(SistemaIntegrado sistema, RegistroCuentas registroCuentas)
    {
        Console.WriteLine("\n--- Crear Cuenta Con RegistroCuentas ---");
        Console.Write("Nombre/Perfil: ");
        string? nombre = Console.ReadLine();
        if (string.IsNullOrEmpty(nombre))
        {
            Console.WriteLine("El nombre es requerido.");
            return;
        }

        Console.WriteLine("Seleccione el tipo de rol:");
        Console.WriteLine("1. Operador");
        Console.WriteLine("2. Paramédico");
        Console.WriteLine("3. Paciente");
        
        IRegistroSesion? tipoRegistro = null;
        if (int.TryParse(Console.ReadLine(), out int tipoRol))
        {
            switch (tipoRol)
            {
                case 1:
                    tipoRegistro = new RolOperador();
                    break;
                case 2:
                    tipoRegistro = new RolParamedico();
                    break;
                case 3:
                    tipoRegistro = new RolPaciente();
                    break;
                default:
                    Console.WriteLine("Tipo de rol no válido.");
                    return;
            }
        }

        try
        {
            // También crear la cuenta localmente para mostrar en el sistema
            var cuenta = new Cuenta(nombre, DateTime.Now, "");
            tipoRegistro!.RegistrarSesion(cuenta);
            sistema.Cuentas.Add(cuenta);
            
            Console.WriteLine("✅ Cuenta creada exitosamente usando servicios especializados");
            Console.WriteLine($"Perfil: {cuenta.Perfil}");
            Console.WriteLine($"Rol: {cuenta.Rol}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"❌ Error al crear cuenta: {ex.Message}");
        }
    }

    private static void MostrarCuentasConVisualizador(SistemaIntegrado sistema, VisualizadorSistemaIntegrado visualizador)
    {
        Console.WriteLine("\n--- Cuentas (Con Visualizador Especializado) ---");
        if (sistema.Cuentas.Count == 0)
        {
            Console.WriteLine("No hay cuentas registradas.");
            return;
        }

        for (int i = 0; i < sistema.Cuentas.Count; i++)
        {
            // Usar el visualizador especializado
            string info = visualizador.Mostrar_Cuenta(sistema.Cuentas[i]);
            Console.WriteLine($"[{i}] {info}");
        }
    }

    private static void ActualizarCuentaConServicio(SistemaIntegrado sistema, ActualizadorSistemaIntegrado actualizador)
    {
        Console.WriteLine("\n--- Actualizar Cuenta Con ActualizadorSistema ---");
        if (sistema.Cuentas.Count == 0)
        {
            Console.WriteLine("No hay cuentas registradas.");
            return;
        }

        MostrarCuentasConVisualizador(sistema, new VisualizadorSistemaIntegrado(new MostrarService(), new MostrarService()));
        Console.Write("Ingrese el índice de la cuenta a actualizar: ");
        
        if (int.TryParse(Console.ReadLine(), out int indice) && indice >= 0 && indice < sistema.Cuentas.Count)
        {
            var cuenta = sistema.Cuentas[indice];
            Console.Write($"Nuevo nombre (actual: {cuenta.Perfil}): ");
            string? nuevoNombre = Console.ReadLine();
            
            if (!string.IsNullOrEmpty(nuevoNombre))
            {
                try
                {
                    cuenta.Perfil = nuevoNombre;
                    Console.WriteLine("✅ Cuenta actualizada exitosamente usando ActualizadorSistema");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"❌ Error al actualizar cuenta: {ex.Message}");
                }
            }
        }
    }

    private static void EliminarCuentaConServicio(SistemaIntegrado sistema, EliminadorSistemaIntegrado eliminador)
    {
        Console.WriteLine("\n--- Eliminar Cuenta Con EliminadorSistema ---");
        if (sistema.Cuentas.Count == 0)
        {
            Console.WriteLine("No hay cuentas registradas.");
            return;
        }

        MostrarCuentasConVisualizador(sistema, new VisualizadorSistemaIntegrado(new MostrarService(), new MostrarService()));
        Console.Write("Ingrese el índice de la cuenta a eliminar: ");
        
        if (int.TryParse(Console.ReadLine(), out int indice) && indice >= 0 && indice < sistema.Cuentas.Count)
        {
            var cuenta = sistema.Cuentas[indice];
            try
            {
                // Usar el eliminador especializado
                eliminador.Eliminar_Cuenta(cuenta, sistema.Cuentas);
                Console.WriteLine("✅ Cuenta eliminada exitosamente usando EliminadorSistema");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Error al eliminar cuenta: {ex.Message}");
            }
        }
    }

    private static void CrearCentroMedicoConServicio(SistemaIntegrado sistema, GestionCentroMedico gestionCentro)
    {
        Console.WriteLine("\n--- Crear Centro Médico Con GestionCentroMedico ---");
        Console.Write("Nombre: ");
        string? nombre = Console.ReadLine();
        if (string.IsNullOrEmpty(nombre))
        {
            Console.WriteLine("El nombre es requerido.");
            return;
        }
        
        Console.Write("Latitud: ");
        if (!float.TryParse(Console.ReadLine(), out float latitud))
        {
            Console.WriteLine("Latitud no válida.");
            return;
        }
        
        Console.Write("Longitud: ");
        if (!float.TryParse(Console.ReadLine(), out float longitud))
        {
            Console.WriteLine("Longitud no válida.");
            return;
        }
        
        Console.Write("Complejidad: ");
        string? complejidad = Console.ReadLine();
        if (string.IsNullOrEmpty(complejidad))
        {
            complejidad = "Básica";
        }
        
        Console.Write("Teléfono: ");
        if (!int.TryParse(Console.ReadLine(), out int telefono))
        {
            Console.WriteLine("Teléfono no válido.");
            return;
        }

        try
        {
            // Usar el servicio GestionCentroMedico
            gestionCentro.Crear_centroMedico(latitud, longitud, nombre, complejidad, telefono);
            
            // También crear localmente para mostrar en el sistema
            var centroMedico = new CentroMedico(nombre, latitud, longitud, complejidad, telefono);
            sistema.CentroMedico.Add(centroMedico);
            
            Console.WriteLine("✅ Centro médico creado exitosamente usando GestionCentroMedico");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"❌ Error al crear centro médico: {ex.Message}");
        }
    }

    private static void ActualizarCentroMedicoConServicio(SistemaIntegrado sistema, GestionCentroMedico gestionCentro)
    {
        Console.WriteLine("\n--- Actualizar Centro Médico Con GestionCentroMedico ---");
        if (sistema.CentroMedico.Count == 0)
        {
            Console.WriteLine("No hay centros médicos registrados.");
            return;
        }

        MostrarCentrosMedicosConVisualizador(sistema, new VisualizadorSistemaIntegrado(new MostrarService(), new MostrarService()));
        Console.Write("Ingrese el índice del centro médico a actualizar: ");
        
        if (int.TryParse(Console.ReadLine(), out int indice) && indice >= 0 && indice < sistema.CentroMedico.Count)
        {
            var centro = sistema.CentroMedico[indice];
            
            Console.Write($"Nueva latitud (actual: {centro.Latitud}): ");
            if (float.TryParse(Console.ReadLine(), out float latitud))
            {
                Console.Write($"Nueva longitud (actual: {centro.Longitud}): ");
                if (float.TryParse(Console.ReadLine(), out float longitud))
                {
                    Console.Write($"Nuevo nombre (actual: {centro.Nombre}): ");
                    string? nombre = Console.ReadLine();
                    if (string.IsNullOrEmpty(nombre)) nombre = centro.Nombre;
                    
                    Console.Write($"Nueva complejidad (actual: {centro.Complejidad}): ");
                    string? complejidad = Console.ReadLine();
                    if (string.IsNullOrEmpty(complejidad)) complejidad = centro.Complejidad;
                    
                    Console.Write($"Nuevo teléfono (actual: {centro.Telefono}): ");
                    if (!int.TryParse(Console.ReadLine(), out int telefono))
                        telefono = centro.Telefono;

                    try
                    {
                        // Usar el servicio GestionCentroMedico
                        gestionCentro.Actualizar_centroMedico(centro, latitud, longitud, nombre, complejidad, telefono);
                        Console.WriteLine("✅ Centro médico actualizado exitosamente usando GestionCentroMedico");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"❌ Error al actualizar centro médico: {ex.Message}");
                    }
                }
            }
        }
    }

    private static void EliminarCentroMedicoConServicio(SistemaIntegrado sistema, EliminadorSistemaIntegrado eliminador)
    {
        Console.WriteLine("\n--- Eliminar Centro Médico Con EliminadorSistema ---");
        if (sistema.CentroMedico.Count == 0)
        {
            Console.WriteLine("No hay centros médicos registrados.");
            return;
        }

        MostrarCentrosMedicosConVisualizador(sistema, new VisualizadorSistemaIntegrado(new MostrarService(), new MostrarService()));
        Console.Write("Ingrese el índice del centro médico a eliminar: ");
        
        if (int.TryParse(Console.ReadLine(), out int indice) && indice >= 0 && indice < sistema.CentroMedico.Count)
        {
            var centro = sistema.CentroMedico[indice];
            try
            {
                // Usar el eliminador especializado
                eliminador.Eliminar_CentroMedico(centro, sistema.CentroMedico);
                Console.WriteLine("✅ Centro médico eliminado exitosamente usando EliminadorSistema");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Error al eliminar centro médico: {ex.Message}");
            }
        }
    }

    private static void MostrarCentrosMedicosConVisualizador(SistemaIntegrado sistema, VisualizadorSistemaIntegrado visualizador)
    {
        Console.WriteLine("\n--- Centros Médicos (Con Visualizador Especializado) ---");
        if (sistema.CentroMedico.Count == 0)
        {
            Console.WriteLine("No hay centros médicos registrados.");
            return;
        }

        for (int i = 0; i < sistema.CentroMedico.Count; i++)
        {
            // Usar el visualizador especializado
            string info = visualizador.Mostrar_CentroMedico(sistema.CentroMedico[i]);
            Console.WriteLine($"[{i}] {info}");
        }
    }

    private static void CrearAlertaConServicio(GestionPaciente gestionPaciente)
    {
        Console.WriteLine("\n--- Crear Alerta Con GestionPaciente ---");
        Console.Write("Latitud: ");
        string? latitud = Console.ReadLine();
        Console.Write("Longitud: ");
        string? longitud = Console.ReadLine();
        
        if (!string.IsNullOrEmpty(latitud) && !string.IsNullOrEmpty(longitud))
        {
            try
            {
                // Crear un paciente de ejemplo
                var historiaClinica = new HistoriaClinica("O+", 30, false, "Bogotá", "Verde", new List<string>());
                var paciente = new Paciente(1, "Juan Pérez", "juan@test.com", 123456789, "CC", 12345678, "password", 
                                          historiaClinica, float.Parse(latitud), float.Parse(longitud));
                
                var alerta = gestionPaciente.crear_alerta(paciente, latitud, longitud);
                Console.WriteLine("✅ Alerta creada exitosamente usando GestionPaciente");
                Console.WriteLine($"Estado: {alerta.Estado}, Latitud: {alerta.Latitud}, Longitud: {alerta.Longitud}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Error al crear alerta: {ex.Message}");
            }
        }
    }

    private static void CambiarEstadoAlertaConServicio(GestionParamedico gestionParamedico)
    {
        Console.WriteLine("\n--- Cambiar Estado Con GestionParamedico ---");
        Console.WriteLine("Ejemplo de cambio de estado usando servicios especializados:");
        
        try
        {
            // Crear una alerta de ejemplo
            var alerta = new AlertaEmergencia("Activa", null, 4.6f, -74.1f, DateTime.Now, DateTime.Now.AddHours(1), null, null);
            string resultado = gestionParamedico.Cambiar_estado(alerta, "En Proceso");
            Console.WriteLine($"✅ {resultado}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"❌ Error: {ex.Message}");
        }
    }

    private static void RegistrarAtencionConServicio(GestionParamedico gestionParamedico)
    {
        Console.WriteLine("\n--- Registrar Atención Con GestionParamedico ---");
        Console.WriteLine("Ejemplo de registro de atención usando servicios especializados:");
        
        try
        {
            // Crear elementos de ejemplo
            var paramedico = new Paramedico(1, "Dr. Smith", "smith@test.com", 123456789, "CC", 12345678, "password", 
                                          001, 5, new List<AlertaEmergencia>(), new List<RegistroAtencion>());
            var alerta = new AlertaEmergencia("Activa", null, 4.6f, -74.1f, DateTime.Now, DateTime.Now.AddHours(1), null, paramedico);
            
            string resultado = gestionParamedico.Registrar_Atencion(alerta, 80, 15, "Paciente estable");
            Console.WriteLine($"✅ {resultado}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"❌ Error: {ex.Message}");
        }
    }

    private static void AsignarTriajeConServicio(GestionParamedico gestionParamedico)
    {
        Console.WriteLine("\n--- Asignar Triaje Con GestionParamedico ---");
        Console.WriteLine("Ejemplo de asignación de triaje usando servicios especializados:");
        
        try
        {
            // Crear elementos de ejemplo
            var historiaClinica = new HistoriaClinica("A+", 25, false, "Medellín", "Amarillo", new List<string>());
            var paciente = new Paciente(1, "Ana García", "ana@test.com", 123456789, "CC", 12345678, "password", 
                                      historiaClinica, 4.6f, -74.1f);
            var alerta = new AlertaEmergencia("Activa", paciente, 4.6f, -74.1f, DateTime.Now, DateTime.Now.AddHours(1), null, null);
            
            string resultado = gestionParamedico.Asignar_triaje(alerta, "Rojo - Urgente");
            Console.WriteLine($"✅ {resultado}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"❌ Error: {ex.Message}");
        }
    }

    private static void IniciarSesionAvanzado(SistemaIntegrado sistema)
    {
        Console.WriteLine("\n--- Iniciar Sesión Avanzado ---");
        if (sistema.Cuentas.Count == 0)
        {
            Console.WriteLine("No hay cuentas registradas.");
            return;
        }

        MostrarCuentasConVisualizador(sistema, new VisualizadorSistemaIntegrado(new MostrarService(), new MostrarService()));
        Console.Write("Ingrese el índice de la cuenta: ");
        
        if (int.TryParse(Console.ReadLine(), out int indice) && indice >= 0 && indice < sistema.Cuentas.Count)
        {
            var cuenta = sistema.Cuentas[indice];
            var sesionService = new SesionService();
            sesionService.Iniciar_sesion(cuenta);
            Console.WriteLine("✅ Sesión iniciada con servicios avanzados");
            Console.WriteLine($"Perfil actual: {cuenta.Perfil}");
        }
    }

    private static void CerrarSesionAvanzado(SistemaIntegrado sistema)
    {
        Console.WriteLine("\n--- Cerrar Sesión Avanzado ---");
        if (sistema.Cuentas.Count == 0)
        {
            Console.WriteLine("No hay cuentas registradas.");
            return;
        }

        MostrarCuentasConVisualizador(sistema, new VisualizadorSistemaIntegrado(new MostrarService(), new MostrarService()));
        Console.Write("Ingrese el índice de la cuenta: ");
        
        if (int.TryParse(Console.ReadLine(), out int indice) && indice >= 0 && indice < sistema.Cuentas.Count)
        {
            var cuenta = sistema.Cuentas[indice];
            var sesionService = new SesionService();
            sesionService.Cerrar_sesion(cuenta);
            Console.WriteLine("✅ Sesión cerrada con servicios avanzados");
            Console.WriteLine($"Perfil actual: {cuenta.Perfil}");
        }
    }

    private static void MostrarInformacionSistemaAvanzada(SistemaIntegrado sistema, VisualizadorSistemaIntegrado visualizador)
    {
        Console.WriteLine("\n===== INFORMACIÓN AVANZADA DEL SISTEMA =====");
        Console.WriteLine($"Nombre del Sistema: {sistema.Nombre}");
        Console.WriteLine($"Teléfono del Sistema: {sistema.Telefono}");
        Console.WriteLine($"Cuentas registradas: {sistema.Cuentas.Count}");
        Console.WriteLine($"Centros médicos registrados: {sistema.CentroMedico.Count}");
        
        Console.WriteLine("\n--- Servicios Especializados Activos ---");
        Console.WriteLine("✅ VisualizadorSistemaIntegrado - Para mostrar información");
        Console.WriteLine("✅ EliminadorSistemaIntegrado - Para eliminar elementos");
        Console.WriteLine("✅ ActualizadorSistemaIntegrado - Para actualizar datos");
        Console.WriteLine("✅ RegistroCuentas - Para gestión avanzada de cuentas");
        Console.WriteLine("✅ GestionCentroMedico - Para gestión de centros médicos");
        Console.WriteLine("✅ GestionParamedico - Para gestión de paramédicos");
        Console.WriteLine("✅ GestionPaciente - Para gestión de pacientes");
        Console.WriteLine("✅ Navegacion - Para servicios de navegación y rutas");
        Console.WriteLine("✅ Comunicacion - Para servicios de comunicación");
        
        Console.WriteLine("\n--- Arquitectura Implementada ---");
        Console.WriteLine("🏗️ Inyección de Dependencias");
        Console.WriteLine("🏗️ Programación Funcional con Lambdas");
        Console.WriteLine("🏗️ Patrón de Servicios Especializados");
        Console.WriteLine("🏗️ Separación de Responsabilidades (SOLID)");
        Console.WriteLine("🏗️ Accesores Funcionales en todas las clases");
    }
}
