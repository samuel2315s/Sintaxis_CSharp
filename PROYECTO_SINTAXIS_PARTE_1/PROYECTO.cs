using System;

class Program
{
    // =====================================================
    // PUNTO DE ENTRADA
    // =====================================================
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        MenuPrincipal();
    }

    // =====================================================
    // UTILIDADES
    // =====================================================
    static int LeerOpcion()
    {
        Console.Write("Elige una opción: ");
        string entrada = Console.ReadLine() ?? "";
        return int.TryParse(entrada, out int opcion) ? opcion : -1;
    }

    static void OpcionInvalida()
    {
        Console.WriteLine("Opción no válida. Intenta de nuevo.");
    }

    static void Pausa()
    {
        Console.WriteLine("\nPresiona Enter para continuar...");
        Console.ReadLine();
    }

    static bool Confirmar(string pregunta)
    {
        string respuesta;
        do
        {
            Console.Write($"{pregunta} (S/N): ");
            respuesta = (Console.ReadLine() ?? "").Trim().ToUpper();
        } while (respuesta != "S" && respuesta != "N");

        return respuesta == "S";
    }

    // =====================================================
    // MENÚ PRINCIPAL
    // =====================================================
    static void MenuPrincipal()
    {
        int opcion;

        do
        {
            Console.WriteLine("\n=== SISTEMA DE BIBLIOTECA ===");
            Console.WriteLine("1. Libros");
            Console.WriteLine("2. Usuarios");
            Console.WriteLine("3. Préstamos");
            Console.WriteLine("4. Búsquedas y reportes");
            Console.WriteLine("5. Guardar / Cargar datos");
            Console.WriteLine("6. Salir");
            opcion = LeerOpcion();

            switch (opcion)
            {
                case 1: MenuLibros(); break;
                case 2: MenuUsuarios(); break;
                case 3: MenuPrestamos(); break;
                case 4: MenuBusquedasReportes(); break;
                case 5: MenuGuardarCargar(); break;
                case 6: Salir(); break;
                default: OpcionInvalida(); break;
            }
        } while (opcion != 6);
    }

    static void Salir()
    {
        if (Confirmar("¿Guardar antes de salir?"))
        {
            GuardarDatos();
        }
        Console.WriteLine("Hasta luego.");
    }

    // =====================================================
    // 1) LIBROS
    // =====================================================
    static void MenuLibros()
    {
        int opcion;

        do
        {
            Console.WriteLine("\n=== LIBROS ===");
            Console.WriteLine("1. Registrar libro");
            Console.WriteLine("2. Listar libros");
            Console.WriteLine("3. Ver detalle de libro (por ID/ISBN)");
            Console.WriteLine("4. Actualizar libro");
            Console.WriteLine("5. Eliminar libro");
            Console.WriteLine("0. Volver al menú principal");
            opcion = LeerOpcion();

            switch (opcion)
            {
                case 1: RegistrarLibro(); break;
                case 2: MenuListarLibros(); break;
                case 3: VerDetalleLibro(); break;
                case 4: MenuActualizarLibro(); break;
                case 5: EliminarLibro(); break;
                case 0: break;
                default: OpcionInvalida(); break;
            }
        } while (opcion != 0);
    }

    static void MenuListarLibros()
    {
        int opcion;

        do
        {
            Console.WriteLine("\n--- Listar libros ---");
            Console.WriteLine("1. Listar todos");
            Console.WriteLine("2. Listar disponibles");
            Console.WriteLine("3. Listar prestados");
            Console.WriteLine("0. Volver");
            opcion = LeerOpcion();

            switch (opcion)
            {
                case 1: ListarLibrosTodos(); break;
                case 2: ListarLibrosDisponibles(); break;
                case 3: ListarLibrosPrestados(); break;
                case 0: break;
                default: OpcionInvalida(); break;
            }
        } while (opcion != 0);
    }

    static void MenuActualizarLibro()
    {
        int opcion;

        do
        {
            Console.WriteLine("\n--- Actualizar libro ---");
            Console.WriteLine("1. Editar título");
            Console.WriteLine("2. Editar autor");
            Console.WriteLine("3. Editar año / categoría");
            Console.WriteLine("0. Volver");
            opcion = LeerOpcion();

            switch (opcion)
            {
                case 1: EditarTituloLibro(); break;
                case 2: EditarAutorLibro(); break;
                case 3: EditarAnioCategoriaLibro(); break;
                case 0: break;
                default: OpcionInvalida(); break;
            }
        } while (opcion != 0);
    }

    static void RegistrarLibro() => Console.WriteLine("[Libros] Registrando un nuevo libro...");
    static void ListarLibrosTodos() => Console.WriteLine("[Libros] Listando todos los libros...");
    static void ListarLibrosDisponibles() => Console.WriteLine("[Libros] Listando los libros disponibles...");
    static void ListarLibrosPrestados() => Console.WriteLine("[Libros] Listando los libros prestados...");
    static void VerDetalleLibro() => Console.WriteLine("[Libros] Mostrando el detalle del libro (por ID/ISBN)...");
    static void EditarTituloLibro() => Console.WriteLine("[Libros] Editando el título del libro...");
    static void EditarAutorLibro() => Console.WriteLine("[Libros] Editando el autor del libro...");
    static void EditarAnioCategoriaLibro() => Console.WriteLine("[Libros] Editando el año y la categoría del libro...");
    static void EliminarLibro() => Console.WriteLine("[Libros] Eliminando libro (se validará que no esté prestado)...");

    // =====================================================
    // 2) USUARIOS
    // =====================================================
    static void MenuUsuarios()
    {
        int opcion;

        do
        {
            Console.WriteLine("\n=== USUARIOS ===");
            Console.WriteLine("1. Registrar usuario");
            Console.WriteLine("2. Listar usuarios");
            Console.WriteLine("3. Ver detalle de usuario (por ID/documento)");
            Console.WriteLine("4. Actualizar usuario");
            Console.WriteLine("5. Eliminar usuario");
            Console.WriteLine("0. Volver al menú principal");
            opcion = LeerOpcion();

            switch (opcion)
            {
                case 1: RegistrarUsuario(); break;
                case 2: ListarUsuarios(); break;
                case 3: VerDetalleUsuario(); break;
                case 4: MenuActualizarUsuario(); break;
                case 5: EliminarUsuario(); break;
                case 0: break;
                default: OpcionInvalida(); break;
            }
        } while (opcion != 0);
    }

    static void MenuActualizarUsuario()
    {
        int opcion;

        do
        {
            Console.WriteLine("\n--- Actualizar usuario ---");
            Console.WriteLine("1. Editar nombre");
            Console.WriteLine("2. Editar contacto");
            Console.WriteLine("3. Activar / desactivar");
            Console.WriteLine("0. Volver");
            opcion = LeerOpcion();

            switch (opcion)
            {
                case 1: EditarNombreUsuario(); break;
                case 2: EditarContactoUsuario(); break;
                case 3: ActivarDesactivarUsuario(); break;
                case 0: break;
                default: OpcionInvalida(); break;
            }
        } while (opcion != 0);
    }

    static void RegistrarUsuario() => Console.WriteLine("[Usuarios] Registrando un nuevo usuario...");
    static void ListarUsuarios() => Console.WriteLine("[Usuarios] Listando los usuarios...");
    static void VerDetalleUsuario() => Console.WriteLine("[Usuarios] Mostrando el detalle del usuario (por ID/documento)...");
    static void EditarNombreUsuario() => Console.WriteLine("[Usuarios] Editando el nombre del usuario...");
    static void EditarContactoUsuario() => Console.WriteLine("[Usuarios] Editando el contacto del usuario...");
    static void ActivarDesactivarUsuario() => Console.WriteLine("[Usuarios] Activando o desactivando al usuario...");
    static void EliminarUsuario() => Console.WriteLine("[Usuarios] Eliminando usuario (se validará que no tenga préstamos activos)...");

    // =====================================================
    // 3) PRÉSTAMOS
    // =====================================================
    static void MenuPrestamos()
    {
        int opcion;

        do
        {
            Console.WriteLine("\n=== PRÉSTAMOS ===");
            Console.WriteLine("1. Crear préstamo");
            Console.WriteLine("2. Listar préstamos");
            Console.WriteLine("3. Ver detalle de préstamo (por ID)");
            Console.WriteLine("4. Registrar devolución");
            Console.WriteLine("5. Eliminar préstamo");
            Console.WriteLine("0. Volver al menú principal");
            opcion = LeerOpcion();

            switch (opcion)
            {
                case 1: CrearPrestamo(); break;
                case 2: MenuListarPrestamos(); break;
                case 3: VerDetallePrestamo(); break;
                case 4: RegistrarDevolucion(); break;
                case 5: EliminarPrestamo(); break;
                case 0: break;
                default: OpcionInvalida(); break;
            }
        } while (opcion != 0);
    }

    static void MenuListarPrestamos()
    {
        int opcion;

        do
        {
            Console.WriteLine("\n--- Listar préstamos ---");
            Console.WriteLine("1. Todos");
            Console.WriteLine("2. Activos");
            Console.WriteLine("3. Cerrados (devueltos)");
            Console.WriteLine("0. Volver");
            opcion = LeerOpcion();

            switch (opcion)
            {
                case 1: ListarPrestamosTodos(); break;
                case 2: ListarPrestamosActivos(); break;
                case 3: ListarPrestamosCerrados(); break;
                case 0: break;
                default: OpcionInvalida(); break;
            }
        } while (opcion != 0);
    }

    static void CrearPrestamo()
    {
        Console.WriteLine("[Préstamos] Creando un nuevo préstamo...");
        Console.WriteLine("   - Se validará que el usuario exista y esté activo.");
        Console.WriteLine("   - Se validará que el libro exista y esté disponible.");
        Console.WriteLine("   - (Opcional) Se validará el máximo de préstamos activos por usuario.");
    }

    static void ListarPrestamosTodos() => Console.WriteLine("[Préstamos] Listando todos los préstamos...");
    static void ListarPrestamosActivos() => Console.WriteLine("[Préstamos] Listando los préstamos activos...");
    static void ListarPrestamosCerrados() => Console.WriteLine("[Préstamos] Listando los préstamos cerrados (devueltos)...");
    static void VerDetallePrestamo() => Console.WriteLine("[Préstamos] Mostrando el detalle del préstamo (por ID)...");

    static void RegistrarDevolucion()
    {
        Console.WriteLine("[Préstamos] Registrando devolución...");
        Console.WriteLine("   - El préstamo pasará a estado \"devuelto\".");
        Console.WriteLine("   - El libro quedará marcado como \"disponible\".");
    }

    static void EliminarPrestamo()
    {
        Console.WriteLine("[Préstamos] Eliminando préstamo...");
        Console.WriteLine("   - Solo si está cerrado o fue creado por error.");
        Console.WriteLine("   - Si estaba activo, el libro se devolverá automáticamente.");
    }

    // =====================================================
    // 4) BÚSQUEDAS Y REPORTES
    // =====================================================
    static void MenuBusquedasReportes()
    {
        int opcion;

        do
        {
            Console.WriteLine("\n=== BÚSQUEDAS Y REPORTES ===");
            Console.WriteLine("1. Buscar libro");
            Console.WriteLine("2. Buscar usuario");
            Console.WriteLine("3. Reportes");
            Console.WriteLine("0. Volver al menú principal");
            opcion = LeerOpcion();

            switch (opcion)
            {
                case 1: MenuBuscarLibro(); break;
                case 2: MenuBuscarUsuario(); break;
                case 3: MenuReportes(); break;
                case 0: break;
                default: OpcionInvalida(); break;
            }
        } while (opcion != 0);
    }

    static void MenuBuscarLibro()
    {
        int opcion;

        do
        {
            Console.WriteLine("\n--- Buscar libro ---");
            Console.WriteLine("1. Por título");
            Console.WriteLine("2. Por autor");
            Console.WriteLine("3. Por ID/ISBN");
            Console.WriteLine("4. Por categoría");
            Console.WriteLine("0. Volver");
            opcion = LeerOpcion();

            switch (opcion)
            {
                case 1: BuscarLibroPorTitulo(); break;
                case 2: BuscarLibroPorAutor(); break;
                case 3: BuscarLibroPorId(); break;
                case 4: BuscarLibroPorCategoria(); break;
                case 0: break;
                default: OpcionInvalida(); break;
            }
        } while (opcion != 0);
    }

    static void MenuBuscarUsuario()
    {
        int opcion;

        do
        {
            Console.WriteLine("\n--- Buscar usuario ---");
            Console.WriteLine("1. Por nombre");
            Console.WriteLine("2. Por ID/documento");
            Console.WriteLine("0. Volver");
            opcion = LeerOpcion();

            switch (opcion)
            {
                case 1: BuscarUsuarioPorNombre(); break;
                case 2: BuscarUsuarioPorId(); break;
                case 0: break;
                default: OpcionInvalida(); break;
            }
        } while (opcion != 0);
    }

    static void MenuReportes()
    {
        int opcion;

        do
        {
            Console.WriteLine("\n--- Reportes ---");
            Console.WriteLine("1. Préstamos por usuario");
            Console.WriteLine("2. Préstamos por libro");
            Console.WriteLine("3. Préstamos vencidos");
            Console.WriteLine("4. Resumen general (total / disponibles / prestados)");
            Console.WriteLine("0. Volver");
            opcion = LeerOpcion();

            switch (opcion)
            {
                case 1: ReportePrestamosPorUsuario(); break;
                case 2: ReportePrestamosPorLibro(); break;
                case 3: ReportePrestamosVencidos(); break;
                case 4: ReporteResumenGeneral(); break;
                case 0: break;
                default: OpcionInvalida(); break;
            }
        } while (opcion != 0);
    }

    static void BuscarLibroPorTitulo() => Console.WriteLine("[Búsqueda] Buscando libro por título...");
    static void BuscarLibroPorAutor() => Console.WriteLine("[Búsqueda] Buscando libro por autor...");
    static void BuscarLibroPorId() => Console.WriteLine("[Búsqueda] Buscando libro por ID/ISBN...");
    static void BuscarLibroPorCategoria() => Console.WriteLine("[Búsqueda] Buscando libro por categoría...");
    static void BuscarUsuarioPorNombre() => Console.WriteLine("[Búsqueda] Buscando usuario por nombre...");
    static void BuscarUsuarioPorId() => Console.WriteLine("[Búsqueda] Buscando usuario por ID/documento...");
    static void ReportePrestamosPorUsuario() => Console.WriteLine("[Reporte] Generando reporte de préstamos por usuario...");
    static void ReportePrestamosPorLibro() => Console.WriteLine("[Reporte] Generando reporte de préstamos por libro...");
    static void ReportePrestamosVencidos() => Console.WriteLine("[Reporte] Generando reporte de préstamos vencidos...");
    static void ReporteResumenGeneral() => Console.WriteLine("[Reporte] Generando resumen general: total de libros / disponibles / prestados...");

    // =====================================================
    // 5) GUARDAR / CARGAR DATOS
    // =====================================================
    static void MenuGuardarCargar()
    {
        int opcion;

        do
        {
            Console.WriteLine("\n=== GUARDAR / CARGAR DATOS ===");
            Console.WriteLine("1. Guardar datos");
            Console.WriteLine("2. Cargar datos");
            Console.WriteLine("3. Reiniciar datos (vaciar todo)");
            Console.WriteLine("0. Volver al menú principal");
            opcion = LeerOpcion();

            switch (opcion)
            {
                case 1: GuardarDatos(); break;
                case 2: CargarDatos(); break;
                case 3: ReiniciarDatos(); break;
                case 0: break;
                default: OpcionInvalida(); break;
            }
        } while (opcion != 0);
    }

    static void GuardarDatos() => Console.WriteLine("[Datos] Guardando libros, usuarios y préstamos...");
    static void CargarDatos() => Console.WriteLine("[Datos] Cargando libros, usuarios y préstamos...");

    static void ReiniciarDatos()
    {
        if (Confirmar("Esto vaciará todos los datos. ¿Estás seguro?"))
        {
            Console.WriteLine("[Datos] Reiniciando datos: se vaciaron libros, usuarios y préstamos.");
        }
        else
        {
            Console.WriteLine("[Datos] Operación cancelada.");
        }
    }
}