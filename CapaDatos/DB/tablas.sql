/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2012                    */
/* Created on:     23/10/2023 20:40:41                          */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('DOMICILIO') and o.name = 'FK_DOMICILI_DOMICILIO_LOCALIDA')
alter table DOMICILIO
   drop constraint FK_DOMICILI_DOMICILIO_LOCALIDA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('GASTO') and o.name = 'FK_GASTO_CATEGORIA_CATEGORI')
alter table GASTO
   drop constraint FK_GASTO_CATEGORIA_CATEGORI
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('GASTO') and o.name = 'FK_GASTO_USUARIO_G_USUARIO')
alter table GASTO
   drop constraint FK_GASTO_USUARIO_G_USUARIO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('INGRESO') and o.name = 'FK_INGRESO_CATEGORIA_CATEGORI')
alter table INGRESO
   drop constraint FK_INGRESO_CATEGORIA_CATEGORI
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('INGRESO') and o.name = 'FK_INGRESO_USUARIO_I_USUARIO')
alter table INGRESO
   drop constraint FK_INGRESO_USUARIO_I_USUARIO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('LOCALIDAD') and o.name = 'FK_LOCALIDA_PROVINCIA_PROVINCI')
alter table LOCALIDAD
   drop constraint FK_LOCALIDA_PROVINCIA_PROVINCI
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('"PLAN"') and o.name = 'FK_PLAN_USUARIO_P_USUARIO')
alter table "PLAN"
   drop constraint FK_PLAN_USUARIO_P_USUARIO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PLAN_GASTO') and o.name = 'FK_PLAN_GAS_PLAN_GAST_PLAN')
alter table PLAN_GASTO
   drop constraint FK_PLAN_GAS_PLAN_GAST_PLAN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PLAN_GASTO') and o.name = 'FK_PLAN_GAS_PLAN_GAST_GASTO')
alter table PLAN_GASTO
   drop constraint FK_PLAN_GAS_PLAN_GAST_GASTO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PLAN_INGRESO') and o.name = 'FK_PLAN_ING_PLAN_INGR_PLAN')
alter table PLAN_INGRESO
   drop constraint FK_PLAN_ING_PLAN_INGR_PLAN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PLAN_INGRESO') and o.name = 'FK_PLAN_ING_PLAN_INGR_INGRESO')
alter table PLAN_INGRESO
   drop constraint FK_PLAN_ING_PLAN_INGR_INGRESO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('USUARIO') and o.name = 'FK_USUARIO_DOMICILIO_DOMICILI')
alter table USUARIO
   drop constraint FK_USUARIO_DOMICILIO_DOMICILI
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CATEGORIA')
            and   type = 'U')
   drop table CATEGORIA
go

if exists (select 1
            from  sysobjects
           where  id = object_id('DOMICILIO')
            and   type = 'U')
   drop table DOMICILIO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('GASTO')
            and   type = 'U')
   drop table GASTO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('INGRESO')
            and   type = 'U')
   drop table INGRESO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('LOCALIDAD')
            and   type = 'U')
   drop table LOCALIDAD
go

if exists (select 1
            from  sysobjects
           where  id = object_id('"PLAN"')
            and   type = 'U')
   drop table "PLAN"
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PLAN_GASTO')
            and   type = 'U')
   drop table PLAN_GASTO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PLAN_INGRESO')
            and   type = 'U')
   drop table PLAN_INGRESO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PROVINCIA')
            and   type = 'U')
   drop table PROVINCIA
go

if exists (select 1
            from  sysobjects
           where  id = object_id('USUARIO')
            and   type = 'U')
   drop table USUARIO
go

/*==============================================================*/
/* Table: CATEGORIA                                             */
/*==============================================================*/
create table CATEGORIA (
   ID_CATEGORIA         int                  identity,
   NOMBRE_CATEGORIA     varchar(100)         not null,
   DESCRIPCION_CATEGORIA varchar(200)         not null,
   FCREACION_CATEGORIA  datetime             null default getdate(),
   ESTA_ACTIVA_CATEGORIA bit                  null default 1,
   constraint PK_CATEGORIA primary key nonclustered (ID_CATEGORIA)
)
go

/*==============================================================*/
/* Table: DOMICILIO                                             */
/*==============================================================*/
create table DOMICILIO (
   ID_DOMICILIO         int                  identity,
   ID_LOCALIDAD         int                  not null,
   CALLE_DOMICILIO      varchar(200)         not null,
   NUMERO_DOMICILIO     int                  not null,
   constraint PK_DOMICILIO primary key nonclustered (ID_DOMICILIO)
)
go

/*==============================================================*/
/* Table: GASTO                                                 */
/*==============================================================*/
create table GASTO (
   ID_GASTO             int                  identity,
   ID_USUARIO           int                  not null,
   ID_CATEGORIA         int                  not null,
   IMPORTE_GASTO        decimal(10,2)        not null,
   DESCRIPCION_GASTO    varchar(200)         not null,
   FECHA_GASTO          datetime             null default getdate(),
   ESTA_ACTIVO_GASTO    bit                  null default 1,
   constraint PK_GASTO primary key nonclustered (ID_GASTO)
)
go

/*==============================================================*/
/* Table: INGRESO                                               */
/*==============================================================*/
create table INGRESO (
   ID_INGRESO           int                  identity,
   ID_USUARIO           int                  not null,
   ID_CATEGORIA         int                  not null,
   IMPORTE_INGRESO      decimal(10,2)        not null,
   DESCRIPCION_INGRESO  varchar(200)         not null,
   FECHA_INGRESO        datetime             null default getdate(),
   ESTA_ACTIVO_INGRESO  bit                  null default 1,
   constraint PK_INGRESO primary key nonclustered (ID_INGRESO)
)
go

/*==============================================================*/
/* Table: LOCALIDAD                                             */
/*==============================================================*/
create table LOCALIDAD (
   ID_LOCALIDAD         int                  identity,
   ID_PROVINCIA         int                  not null,
   COD_POSTAL_LOCALIDAD varchar(5)           not null,
   NOMBRE_LOCALIDAD     varchar(100)         not null,
   constraint PK_LOCALIDAD primary key nonclustered (ID_LOCALIDAD)
)
go

/*==============================================================*/
/* Table: "PLAN"                                                */
/*==============================================================*/
create table "PLAN" (
   ID_PLAN              int                  identity,
   ID_USUARIO           int                  not null,
   NOMBRE_PLAN          varchar(100)         not null,
   DESCRIPCION_PLAN     varchar(200)         not null,
   FECHA_INICIO_PLAN    datetime             null default getdate(),
   FECHA_FIN_PLAN       datetime             not null,
   CAPITAL_OBJETIVO_PLAN decimal(10,2)        not null,
   ESTA_ACTIVO_PLAN     bit                  null default 1,
   constraint PK_PLAN primary key nonclustered (ID_PLAN)
)
go

/*==============================================================*/
/* Table: PLAN_GASTO                                            */
/*==============================================================*/
create table PLAN_GASTO (
   ID_PLAN              int                  not null,
   ID_GASTO             int                  not null,
   constraint PK_PLAN_GASTO primary key (ID_PLAN, ID_GASTO)
)
go

/*==============================================================*/
/* Table: PLAN_INGRESO                                          */
/*==============================================================*/
create table PLAN_INGRESO (
   ID_PLAN              int                  not null,
   ID_INGRESO           int                  not null,
   constraint PK_PLAN_INGRESO primary key (ID_PLAN, ID_INGRESO)
)
go

/*==============================================================*/
/* Table: PROVINCIA                                             */
/*==============================================================*/
create table PROVINCIA (
   ID_PROVINCIA         int                  identity,
   NOMBRE_PROVINCIA     varchar(100)         not null,
   constraint PK_PROVINCIA primary key nonclustered (ID_PROVINCIA)
)
go

/*==============================================================*/
/* Table: USUARIO                                               */
/*==============================================================*/
create table USUARIO (
   ID_USUARIO           int                  identity,
   ID_DOMICILIO         int                  not null,
   NOMBRES_USUARIO      varchar(100)         not null,
   APELLIDOS_USUARIO    varchar(100)         not null,
   FNACIMIENTO_PERSONA  datetime             not null,
   DNI_USUARIO          varchar(10)          not null,
   EMAIL_USUARIO        varchar(100)         not null,
   CONTRASENA_USUARIO   varchar(20)          not null,
   ESTA_ACTIVO_USUARIO  bit                  null default 1,
   FCREACION_USUARIO    datetime             null default getdate(),
   constraint PK_USUARIO primary key nonclustered (ID_USUARIO)
)
go

alter table DOMICILIO
   add constraint FK_DOMICILI_DOMICILIO_LOCALIDA foreign key (ID_LOCALIDAD)
      references LOCALIDAD (ID_LOCALIDAD)
go

alter table GASTO
   add constraint FK_GASTO_CATEGORIA_CATEGORI foreign key (ID_CATEGORIA)
      references CATEGORIA (ID_CATEGORIA)
go

alter table GASTO
   add constraint FK_GASTO_USUARIO_G_USUARIO foreign key (ID_USUARIO)
      references USUARIO (ID_USUARIO)
go

alter table INGRESO
   add constraint FK_INGRESO_CATEGORIA_CATEGORI foreign key (ID_CATEGORIA)
      references CATEGORIA (ID_CATEGORIA)
go

alter table INGRESO
   add constraint FK_INGRESO_USUARIO_I_USUARIO foreign key (ID_USUARIO)
      references USUARIO (ID_USUARIO)
go

alter table LOCALIDAD
   add constraint FK_LOCALIDA_PROVINCIA_PROVINCI foreign key (ID_PROVINCIA)
      references PROVINCIA (ID_PROVINCIA)
go

alter table "PLAN"
   add constraint FK_PLAN_USUARIO_P_USUARIO foreign key (ID_USUARIO)
      references USUARIO (ID_USUARIO)
go

alter table PLAN_GASTO
   add constraint FK_PLAN_GAS_PLAN_GAST_PLAN foreign key (ID_PLAN)
      references "PLAN" (ID_PLAN)
go

alter table PLAN_GASTO
   add constraint FK_PLAN_GAS_PLAN_GAST_GASTO foreign key (ID_GASTO)
      references GASTO (ID_GASTO)
go

alter table PLAN_INGRESO
   add constraint FK_PLAN_ING_PLAN_INGR_PLAN foreign key (ID_PLAN)
      references "PLAN" (ID_PLAN)
go

alter table PLAN_INGRESO
   add constraint FK_PLAN_ING_PLAN_INGR_INGRESO foreign key (ID_INGRESO)
      references INGRESO (ID_INGRESO)
go

alter table USUARIO
   add constraint FK_USUARIO_DOMICILIO_DOMICILI foreign key (ID_DOMICILIO)
      references DOMICILIO (ID_DOMICILIO)
go

