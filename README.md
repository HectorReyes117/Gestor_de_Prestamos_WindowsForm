# Gestor_de_Prestamos_WindowsForm

### Tecnologias utilizadas
```
C# Windows Form
Sql Server
Report Viewer
```
### Destalles del Proyecto #
```
Sistema de administracion de prestamos.

Construir una aplicación para que una empresa financiera maneje las operaciones de prestamos de los clientes.
```
### Módulo Mantenimientos 
```
CRUD de Clientes: 
• Id.
• Cedula. 
• Nombre. 
• Correo Electronico. 
• Direccion. 
• Telefono.

CRUD de Prestamos 
• Id 
• Fecha 
• Monto prestamo 
• Cliente (clave foranea) 
• Cuotas (cantidad) 

*IMPORTANTE* Tome en cuenta que debe existir una tabla llamada 
MovimientosPrestamos (o un nombre de su preferencia) Esta tabla va a contener lo 
siguiente: 

• Id 
• Prestamo (clave foranea) 
• Monto pendiente 

El proposito de esta tabla es ir reflejando el balance pendiente de pago. Esta tabla debe 
alimentarla de manera automatica (via SQL, Procedimiento almancenado o cualquier 
otra via) Cada vez que se cree un prestamo, debe crearse un registro en esta tabla. El uso 
de la misma la veremos en el modulo procesos.
```
### Módulo Procesos 
```
Pago de prestamo 

En este proceso se requiere aplicar pagos a los prestamos existentes. Para ello, se elegira 
el cliente, y se cargaran los datos del o de los prestamos que tenga. Al elegir el 
prestamo, debe cargar un formulario donde presente opcion de pagar una cuota o de 
pagar la totalidad de la deuda. 

Si se elige pagar una cuota, el sistema debe calcularle el valor de la cuota (monto 
adeudado / cantidad de cuotas) y presentar ese valor. Cuando el cliente lo pague, debe 
registrar esa informacion en la tabla Pagos (Id, Fecha, Prestamo, Cliente, Monto 
pagado).

Cada pago realizado, debe actualizar la tabla MovimientosPrestamos (o el nombre que 
le haya puesto.) De manera que esa tabla refleje siempre el balance pendiente de pago. 
```
### Módulo Consultas 
```
En este módulo, debe proveer la funcionalidad de consultar y filtrar: 

Los Cliente: 

  • Por nombre 
  • Por cedula 
  • Por Correo electronico 
  
Los Prestamos: 

  • Por fecha 
  • Por cliente 
  
Los Pagos: 
  • Por rango de fechas 
  
Los balances pendientes:

• Aqui se desea consultar los balances pendientes, por prestamos.
```
### Reportes 
```
Agregar la funcionalidad de que desde cada una de las consultas y filtros se pueda 
generar un PDF, para imprimir. 
```

