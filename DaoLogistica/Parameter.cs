namespace DaoLogistica
{
    public enum Select_SQL
    {
        InsertUpdate = 100,
        SetClave=101,
        MarcarIngresouSalida=102,
        InsertDefecto = 103,
        InsertDerivar = 104,
        InsertRelacionado=105,
        Anular = 200,
        DeleteLogico = 300,
        DeleteFisico = 301,
        DeleteForzadoLogico = 302,
        Delete08a12DIG = 303,
        RecuperarLogico=304,
        ExistsId = 400,    //Por COdigo único de Tabla
        ExistSbn=4001,
        ExistGp=4002,
        ExistEmail=401,
        ExistTipoDoc=402,
        ExistRazon=403,
        GetAll = 500,           //Devolver Todos los registros ... ¡Cuidado con esto!
        GetAllEscuelas = 501,       //Devolver Todos los registros ... ¡Cuidado con esto!
        GetById = 511,     //*****************ID
        GetById2 = 512,
        GetByArea = 513,
        GetByAreaReporting = 5131,
        GetbyAreaYCodSubDep = 514,
        GetByClaveUSerie = 515,
        GetByCodDep = 516,
        GetByNombre=517, //ubigeo
        GetByCodAmbiente = 5161,
        GetByCodAmbienteForPrinterBorrador = 5162,
        GetByCodAmbienteForCodBarras01 = 5163,
        GetByCodLocal = 517,
        GetByCodLoginYPeriodo = 518,
        GetByCodPersonal = 519,
        GetByCodProv=5191,
        GetByCodSbn = 520,
        GetByCodSubDep = 521,
        GetByCodTipo = 522,
        GetByCodTipoYReferencia = 523,
        GetByDirec = 524,
        GetByDescrip = 5241,
        GetByDocumento = 525,
        GetByEstado = 526,
        GetByEmail = 527,
        GetByFirmas = 5271,
        GetByGp = 528,
        GetByGrupoClase=5281,
        GetByMatricula = 529,
        GetByNumMotor = 530,
        GetByOficina = 531,
        GetByPeriodo = 532,
        GetByPeriodoYCargo=5321,
        GetByPeriodoYJefe = 5322,
        GetByRazon = 533,
        GetByRubroDependencia = 534,
        GetByReferencia = 5341,
        GetBySerie = 535,
        GetByTipoDoc=536,
        GetClave=538,
        GetEstado=539, //ver estados TAmbienteEstado 23102013
        FiltroBy = 600, //ok utilizado
        
        FiltroByRazon=601,
        FiltroByEmail=602,
        FiltroByCategoria=603,
        FiltroByCodSbn=604,
        FiltroByCodArea = 605,
        FiltroByDoc = 606,
        FiltroByPersonal = 607, //ok utilizado
        FiltroByPrograma = 608, //ok util
        FiltroByDireccion = 609,
        
         //FiltroByDenominacion = 6061,
        //FiltroByCodAreaCuenta = 6051,
        RetornaTotalAfectados=701,
        ImportarFromPrincipal = 801,
        MarcarCantidad = 850,
        ModificarEnBloque = 8501, //bienes
        Mover = 851,
        Clonar = 852,
        SearchBy=901
    }
    public enum Estado_SQL
    {
        Activo_Vigente=1,
        Suspendido_Anulado=2,
        Todos=3
    }

    public enum SqlTipoDevuelto
    {
        Normal=10,
        Borrador=20,
        Resumen=30,
        Detallado = 40,
        CodigoBarras1=50,
        CodigoBarras2=60,
        Todo=70
    }
    /// <summary>
    /// Tipo de Dato que permitira Almacenar Valor NULL a Datos Boolean
    /// </summary>
    public enum Bit
    {
        Nulo = -1,
        Falso,
        Verdadero
    }
}
