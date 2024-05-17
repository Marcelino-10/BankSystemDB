/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2012                    */
/* Created on:     5/15/2024 1:28:06 PM                         */
/*==============================================================*/

/*create database Banks
use Banks*/

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ACCOUNT') and o.name = 'FK_ACCOUNT_BELONGS_CUSTOMER')
alter table ACCOUNT
   drop constraint FK_ACCOUNT_BELONGS_CUSTOMER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ACCOUNT') and o.name = 'FK_ACCOUNT_HAS_BRANCH')
alter table ACCOUNT
   drop constraint FK_ACCOUNT_HAS_BRANCH
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BANK') and o.name = 'FK_BANK_CREATESBA_ADMIN')
alter table BANK
   drop constraint FK_BANK_CREATESBA_ADMIN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BRANCH') and o.name = 'FK_BRANCH_CREATEBRA_ADMIN')
alter table BRANCH
   drop constraint FK_BRANCH_CREATEBRA_ADMIN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BRANCH') and o.name = 'FK_BRANCH_OWNS_BANK')
alter table BRANCH
   drop constraint FK_BRANCH_OWNS_BANK
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CUSTOMERPHONE') and o.name = 'FK_CUSTOMER_HASNUM_CUSTOMER')
alter table CUSTOMERPHONE
   drop constraint FK_CUSTOMER_HASNUM_CUSTOMER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('EMPLOYEE') and o.name = 'FK_EMPLOYEE_WORKS_BRANCH')
alter table EMPLOYEE
   drop constraint FK_EMPLOYEE_WORKS_BRANCH
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('LOAN') and o.name = 'FK_LOAN_OFFERS_BRANCH')
alter table LOAN
   drop constraint FK_LOAN_OFFERS_BRANCH
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TAKELOAN') and o.name = 'FK_TAKELOAN_RELATIONS_CUSTOMER')
alter table TAKELOAN
   drop constraint FK_TAKELOAN_RELATIONS_CUSTOMER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TAKELOAN') and o.name = 'FK_TAKELOAN_RELATIONS_LOAN')
alter table TAKELOAN
   drop constraint FK_TAKELOAN_RELATIONS_LOAN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('"TRANSACTION"') and o.name = 'FK_TRANSACT_MAKES_ACCOUNT')
alter table "TRANSACTION"
   drop constraint FK_TRANSACT_MAKES_ACCOUNT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CUSTOMER') and o.name = 'FK_CUSTOMER_REQUEST_LOAN')
alter table LOAN
   drop constraint FK_CUSTOMER_REQUEST_LOAN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('EMPLOYEE') and o.name = 'FK_EMPLOYEE_ACCEPT_LOAN')
alter table LOAN
   drop constraint FK_EMPLOYEE_ACCEPT_LOAN
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ACCOUNT')
            and   name  = 'BELONGS_FK'
            and   indid > 0
            and   indid < 255)
   drop index ACCOUNT.BELONGS_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ACCOUNT')
            and   name  = 'HAS_FK'
            and   indid > 0
            and   indid < 255)
   drop index ACCOUNT.HAS_FK
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
            from  sysindexes
           where  id    = object_id('BANK')
            and   name  = 'CREATESBANK_FK'
            and   indid > 0
            and   indid < 255)
   drop index BANK.CREATESBANK_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('BANK')
            and   type = 'U')
   drop table BANK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BRANCH')
            and   name  = 'CREATEBRANCH_FK'
            and   indid > 0
            and   indid < 255)
   drop index BRANCH.CREATEBRANCH_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BRANCH')
            and   name  = 'OWNS_FK'
            and   indid > 0
            and   indid < 255)
   drop index BRANCH.OWNS_FK
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
            from  sysindexes
           where  id    = object_id('CUSTOMERPHONE')
            and   name  = 'HASNUM_FK'
            and   indid > 0
            and   indid < 255)
   drop index CUSTOMERPHONE.HASNUM_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CUSTOMERPHONE')
            and   type = 'U')
   drop table CUSTOMERPHONE
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('EMPLOYEE')
            and   name  = 'WORKS_FK'
            and   indid > 0
            and   indid < 255)
   drop index EMPLOYEE.WORKS_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('EMPLOYEE')
            and   type = 'U')
   drop table EMPLOYEE
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('LOAN')
            and   name  = 'OFFERS_FK'
            and   indid > 0
            and   indid < 255)
   drop index LOAN.OFFERS_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('LOAN')
            and   type = 'U')
   drop table LOAN
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TAKELOAN')
            and   name  = 'RELATIONSHIP_6_FK'
            and   indid > 0
            and   indid < 255)
   drop index TAKELOAN.RELATIONSHIP_6_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TAKELOAN')
            and   name  = 'RELATIONSHIP_5_FK'
            and   indid > 0
            and   indid < 255)
   drop index TAKELOAN.RELATIONSHIP_5_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TAKELOAN')
            and   type = 'U')
   drop table TAKELOAN
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('"TRANSACTION"')
            and   name  = 'MAKES_FK'
            and   indid > 0
            and   indid < 255)
   drop index "TRANSACTION".MAKES_FK
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
   ACCOUNTNO_           int                  not null,
   BRANCHNO             int                  not null,
   CUSTOMERSSN          int                  not null,
   BALANCE              float                not null,
   OPENDATE             datetime             not null,
   TYPE                 varchar(50)          not null,
   INTERESTRATE         float                not null,
   constraint PK_ACCOUNT primary key nonclustered (ACCOUNTNO_)
)
go

/*==============================================================*/
/* Index: HAS_FK                                                */
/*==============================================================*/




create nonclustered index HAS_FK on ACCOUNT (BRANCHNO ASC)
go

/*==============================================================*/
/* Index: BELONGS_FK                                            */
/*==============================================================*/




create nonclustered index BELONGS_FK on ACCOUNT (CUSTOMERSSN ASC)
go

/*==============================================================*/
/* Table: ADMIN                                                 */
/*==============================================================*/
create table ADMIN (
   ID                   int                   not null,
   NAME                 varchar(100)          not null,
   PASSWORD             varchar(20)           not null,
   constraint PK_ADMIN primary key nonclustered (ID)
)
go

/*==============================================================*/
/* Table: BANK                                                  */
/*==============================================================*/
create table BANK (
   CODE                 int    identity(100, 1)    not null,
   ADMINID              int                        not null,
   NAME                 varchar(100)               not null,
   ADDRESS              varchar(100)                   null,
   constraint PK_BANK primary key nonclustered (CODE)
)
go

/*==============================================================*/
/* Index: CREATESBANK_FK                                        */
/*==============================================================*/




create nonclustered index CREATESBANK_FK on BANK (ADMINID ASC)
go

/*==============================================================*/
/* Table: BRANCH                                                */
/*==============================================================*/
create table BRANCH (
   BRANCHNO             int       identity(1500, 1)   not null,
   BANKCODE             int                           not null,
   ADMINID              int                           not null,
   ZIPCODE              int                               null,
   CITY                 varchar(30)                   not null,
   ADDRESS              varchar(100)                  not null,
   constraint PK_BRANCH primary key nonclustered (BRANCHNO)
)
go

/*==============================================================*/
/* Index: OWNS_FK                                               */
/*==============================================================*/




create nonclustered index OWNS_FK on BRANCH (BANKCODE ASC)
go

/*==============================================================*/
/* Index: CREATEBRANCH_FK                                       */
/*==============================================================*/




create nonclustered index CREATEBRANCH_FK on BRANCH (ADMINID ASC)
go

/*==============================================================*/
/* Table: CUSTOMER                                              */
/*==============================================================*/
create table CUSTOMER (
   SSN                  int                   not null,
   NAME                 varchar(100)          not null,
   DATEBIRTH            datetime                  null,
   EMAIL                varchar(100)          not null,
   ADDRESS              varchar(100)              null,
   PASSWORD             varchar(20)               null,
   constraint PK_CUSTOMER primary key nonclustered (SSN)
)
go

/*==============================================================*/
/* Table: CUSTOMERPHONE                                         */
/*==============================================================*/
create table CUSTOMERPHONE (
   PHONENUM             varchar(11)          not null,
   SSN                  int                  not null,
   constraint PK_CUSTOMERPHONE primary key nonclustered (PHONENUM, SSN)
)
go

/*==============================================================*/
/* Index: HASNUM_FK                                             */
/*==============================================================*/




create nonclustered index HASNUM_FK on CUSTOMERPHONE (SSN ASC)
go

/*==============================================================*/
/* Table: EMPLOYEE                                              */
/*==============================================================*/
create table EMPLOYEE (
   EMPLOYEEID           int                   not null,
   BRANCHNO             int                   not null,
   NAME                 varchar(100)          not null,
   ADDRESS              varchar(100)              null,
   PHONENUM             varchar(11)           not null,
   TITLE                varchar(20)           not null,
   EMAIL                varchar(100)          not null,
   PASSWORD             varchar(20)               null,
   constraint PK_EMPLOYEE primary key nonclustered (EMPLOYEEID)
)
go

/*==============================================================*/
/* Index: WORKS_FK                                              */
/*==============================================================*/




create nonclustered index WORKS_FK on EMPLOYEE (BRANCHNO ASC)
go

/*==============================================================*/
/* Table: LOAN                                                  */
/*==============================================================*/
create table LOAN (
   LOANNO_              int    identity(512, 1)    not null,
   CUSTOMERSSN          int                        not null,
   EMPLOYEEID           int                            null,
   AMOUNT               float                      not null,
   INTERESTRATE         float                      not null,
   TYPE                 varchar(30)                not null,
   PAYMENTSCHEDULE      varchar(30)                not null,
   STATUS               varchar(20)                    null,
   constraint PK_LOAN primary key nonclustered (LOANNO_)
)
go


/*==============================================================*/
/* Table: "TRANSACTION"                                         */
/*==============================================================*/
create table "TRANSACTION" (
   TRANSACTIONID        int    identity(2000, 1)      not null,
   ACCOUNTNO_           int                           not null,
   TRANSACTIONTYPE      varchar(30)                   not null,
   TRANSACTIONDATE      datetime                      not null,
   AMOUNT               float                         not null,
   constraint PK_TRANSACTION primary key nonclustered (TRANSACTIONID)
)
go

/*==============================================================*/
/* Index: MAKES_FK                                              */
/*==============================================================*/




create nonclustered index MAKES_FK on "TRANSACTION" (ACCOUNTNO_ ASC)
go

alter table ACCOUNT
   add constraint FK_ACCOUNT_BELONGS_CUSTOMER foreign key (CUSTOMERSSN)
      references CUSTOMER (SSN)
go

alter table ACCOUNT
   add constraint FK_ACCOUNT_HAS_BRANCH foreign key (BRANCHNO)
      references BRANCH (BRANCHNO)
go

alter table BANK
   add constraint FK_BANK_CREATESBA_ADMIN foreign key (ADMINID)
      references ADMIN (ID)
go

alter table BRANCH
   add constraint FK_BRANCH_CREATEBRA_ADMIN foreign key (ADMINID)
      references ADMIN (ID)
go

alter table BRANCH
   add constraint FK_BRANCH_OWNS_BANK foreign key (BANKCODE)
      references BANK (CODE)
go

alter table CUSTOMERPHONE
   add constraint FK_CUSTOMER_HASNUM_CUSTOMER foreign key (SSN)
      references CUSTOMER (SSN)
go

alter table EMPLOYEE
   add constraint FK_EMPLOYEE_WORKS_BRANCH foreign key (BRANCHNO)
      references BRANCH (BRANCHNO)
go

alter table LOAN
   add constraint FK_CUSTOMER_REQUEST_LOAN foreign key (CUSTOMERSSN)
      references CUSTOMER (SSN)
go

alter table LOAN
   add constraint FK_EMPLOYEE_ACCEPT_LOAN foreign key (EMPLOYEEID)
      references EMPLOYEE (EMPLOYEEID)
go

alter table "TRANSACTION"
   add constraint FK_TRANSACT_MAKES_ACCOUNT foreign key (ACCOUNTNO_)
      references ACCOUNT (ACCOUNTNO_)
go

