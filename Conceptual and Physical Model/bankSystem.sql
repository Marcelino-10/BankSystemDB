/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2017                    */
/* Created on:     5/19/2024 3:24:15 PM                         */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ACCOUNT') and o.name = 'FK_ACCOUNT_REFERENCE_BRANCH')
alter table ACCOUNT
   drop constraint FK_ACCOUNT_REFERENCE_BRANCH
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ACCOUNT') and o.name = 'FK_ACCOUNT_REFERENCE_CUSTOMER')
alter table ACCOUNT
   drop constraint FK_ACCOUNT_REFERENCE_CUSTOMER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BANK') and o.name = 'FK_BANK_REFERENCE_ADMIN')
alter table BANK
   drop constraint FK_BANK_REFERENCE_ADMIN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BRANCH') and o.name = 'FK_BRANCH_REFERENCE_ADMIN')
alter table BRANCH
   drop constraint FK_BRANCH_REFERENCE_ADMIN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BRANCH') and o.name = 'FK_BRANCH_REFERENCE_BANK')
alter table BRANCH
   drop constraint FK_BRANCH_REFERENCE_BANK
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('EMPLOYEE') and o.name = 'FK_EMPLOYEE_REFERENCE_BRANCH')
alter table EMPLOYEE
   drop constraint FK_EMPLOYEE_REFERENCE_BRANCH
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('LOAN') and o.name = 'FK_LOAN_REFERENCE_CUSTOMER')
alter table LOAN
   drop constraint FK_LOAN_REFERENCE_CUSTOMER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('LOAN') and o.name = 'FK_LOAN_REFERENCE_EMPLOYEE')
alter table LOAN
   drop constraint FK_LOAN_REFERENCE_EMPLOYEE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('"TRANSACTION"') and o.name = 'FK_TRANSACT_REFERENCE_ACCOUNT')
alter table "TRANSACTION"
   drop constraint FK_TRANSACT_REFERENCE_ACCOUNT
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ACCOUNT')
            and   type = 'U')
   drop table ACCOUNT
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ADMIN')
            and   type = 'U')
   drop table ADMIN
go

if exists (select 1
            from  sysobjects
           where  id = object_id('BANK')
            and   type = 'U')
   drop table BANK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('BRANCH')
            and   type = 'U')
   drop table BRANCH
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CUSTOMER')
            and   type = 'U')
   drop table CUSTOMER
go

if exists (select 1
            from  sysobjects
           where  id = object_id('EMPLOYEE')
            and   type = 'U')
   drop table EMPLOYEE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('LOAN')
            and   type = 'U')
   drop table LOAN
go

if exists (select 1
            from  sysobjects
           where  id = object_id('"TRANSACTION"')
            and   type = 'U')
   drop table "TRANSACTION"
go

/*==============================================================*/
/* Table: ACCOUNT                                               */
/*==============================================================*/
create table ACCOUNT (
   ACCOUNTNO_           int      identity(1111, 1)     not null,
   BRANCHNO             int                  not null,
   CUSTOMERSSN          int                  not null,
   BALANCE              float                not null,
   OPENDATE             datetime             not null,
   TYPE                 varchar(50)          not null,
   constraint PK_ACCOUNT primary key (ACCOUNTNO_)
)
go

/*==============================================================*/
/* Table: ADMIN                                                 */
/*==============================================================*/
create table ADMIN (
   ID                   int                  not null,
   NAME                 varchar(100)         not null,
   PASSWORD             varchar(20)          not null,
   constraint PK_ADMIN primary key (ID)
)
go

/*==============================================================*/
/* Table: BANK                                                  */
/*==============================================================*/
create table BANK (
   CODE                 int     identity(100, 1)     not null,
   ADMINID              int                  not null,
   NAME                 varchar(100)         not null,
   ADDRESS              varchar(100)         null,
   constraint PK_BANK primary key (CODE)
)
go

/*==============================================================*/
/* Table: BRANCH                                                */
/*==============================================================*/
create table BRANCH (
   BRANCHNO             int    identity(1500, 1)    not null,
   BANKCODE             int                  not null,
   ADMINID              int                  not null,
   ZIPCODE              int                  null,
   CITY                 varchar(30)          not null,
   ADDRESS              varchar(100)         not null,
   constraint PK_BRANCH primary key (BRANCHNO)
)
go

/*==============================================================*/
/* Table: CUSTOMER                                              */
/*==============================================================*/
create table CUSTOMER (
   SSN                  int                  not null,
   NAME                 varchar(100)         not null,
   DATEBIRTH            datetime             null,
   EMAIL                varchar(100)         not null,
   ADDRESS              varchar(100)         null,
   PASSWORD             varchar(20)          null,
   constraint PK_CUSTOMER primary key (SSN)
)
go

/*==============================================================*/
/* Table: EMPLOYEE                                              */
/*==============================================================*/
create table EMPLOYEE (
   EMPLOYEEID           int                  not null,
   BRANCHNO             int                  not null,
   NAME                 varchar(100)         not null,
   ADDRESS              varchar(100)         null,
   PHONENUM             varchar(11)          not null,
   TITLE                varchar(20)          not null,
   EMAIL                varchar(100)         not null,
   PASSWORD             varchar(20)          null,
   constraint PK_EMPLOYEE primary key (EMPLOYEEID)
)
go

/*==============================================================*/
/* Table: LOAN                                                  */
/*==============================================================*/
create table LOAN (
   LOANNO_              int      identity(512, 1)    not null,
   CUSTOMERSSN          int                  not null,
   EMPLOYEEID           int                  null,
   AMOUNT               float                not null,
   INTERESTRATE         float                not null,
   TYPE                 varchar(30)          not null,
   PAYMENTSCHEDULE      varchar(50)          not null,
   STATUS               varchar(20)          not null,
   constraint PK_LOAN primary key (LOANNO_)
)
go

/*==============================================================*/
/* Table: "TRANSACTION"                                         */
/*==============================================================*/
create table "TRANSACTION" (
   TRANSACTIONID        int    identity(2000, 1)   not null,
   ACCOUNTNO_           int                  not null,
   TRANSACTIONTYPE      varchar(30)          not null,
   TRANSACTIONDATE      datetime             not null,
   AMOUNT               float                not null,
   constraint PK_TRANSACTION primary key (TRANSACTIONID)
)
go

alter table ACCOUNT
   add constraint FK_ACCOUNT_REFERENCE_BRANCH foreign key (BRANCHNO)
      references BRANCH (BRANCHNO)
go

alter table ACCOUNT
   add constraint FK_ACCOUNT_REFERENCE_CUSTOMER foreign key (CUSTOMERSSN)
      references CUSTOMER (SSN)
go

alter table BANK
   add constraint FK_BANK_REFERENCE_ADMIN foreign key (ADMINID)
      references ADMIN (ID)
go

alter table BRANCH
   add constraint FK_BRANCH_REFERENCE_ADMIN foreign key (ADMINID)
      references ADMIN (ID)
go

alter table BRANCH
   add constraint FK_BRANCH_REFERENCE_BANK foreign key (BANKCODE)
      references BANK (CODE)
go

alter table EMPLOYEE
   add constraint FK_EMPLOYEE_REFERENCE_BRANCH foreign key (BRANCHNO)
      references BRANCH (BRANCHNO)
go

alter table LOAN
   add constraint FK_LOAN_REFERENCE_CUSTOMER foreign key (CUSTOMERSSN)
      references CUSTOMER (SSN)
go

alter table LOAN
   add constraint FK_LOAN_REFERENCE_EMPLOYEE foreign key (EMPLOYEEID)
      references EMPLOYEE (EMPLOYEEID)
go

alter table "TRANSACTION"
   add constraint FK_TRANSACT_REFERENCE_ACCOUNT foreign key (ACCOUNTNO_)
      references ACCOUNT (ACCOUNTNO_)
go

