INSERT INTO dbo.InvoiceTypes (Name, CreatedAt, IsDeleted)
VALUES ('Serviço',GETDATE(),0),
('Produto',GETDATE(),0),
('Débito',GETDATE(),0);

INSERT INTO
dbo.Permissions (Name,CreatedAt, IsDeleted)
VALUES
('VIEW',GETDATE(),0),
('EDIT',GETDATE(),0),
('CREATE',GETDATE(),0),
('DELETE',GETDATE(),0);

insert into dbo.Permissions (Name, Description, CreatedAt, IsDeleted)
VALUES ('EDIT_INVOICESTATUS', 'Edit Invoice Status Only',GETDATE(),0) 

INSERT INTO [dbo].[Roles] (Name,CreatedAt, IsDeleted)
VALUES ('Administrador',GETDATE(),0),
('Analista P100',GETDATE(),0),
('Analista Financeiro',GETDATE(),0),
('Analista Consulta',GETDATE(),0);


INSERT INTO dbo.PermissionRole
(RolesId, PermissionsId)
SELECT r.Id, p.Id
FROM dbo.Roles r ,dbo.Permissions p
WHERE r.Name = 'Administrador'

INSERT INTO dbo.PermissionRole
(RolesId, PermissionsId)
SELECT r.Id, p.Id
FROM dbo.Roles r ,dbo.Permissions p
WHERE r.Name = 'Analista P100'
AND p.Name IN ('CREATE','EDIT','VIEW')

INSERT INTO dbo.PermissionRole
(RolesId, PermissionsId)
SELECT r.Id, p.Id
FROM dbo.Roles r ,dbo.Permissions p
WHERE r.Name = 'Analista Financeiro'
AND p.Name IN ('EDIT_INVOICESTATUS','VIEW')

INSERT INTO dbo.PermissionRole
(RolesId, PermissionsId)
SELECT r.Id, p.Id
FROM dbo.Roles r ,dbo.Permissions p
WHERE r.Name = 'Analista Consulta'
AND p.Name IN ('VIEW')

INSERT INTO[dbo].[Users]
(Email, Name,RoleId, CreatedAt, IsDeleted)
VALUES
('edson.cunha@consultant.volvo.com','Edson Cunha',2,GETDATE(),0),
('emanuelly.santos@consultant.volvo.com','Emanuelly Santos',2,GETDATE(),0),
('haphael.vidal@consultant.volvo.com','Haphael Vidal',2,GETDATE(),0),
('jorge.gomes@volvo.com','Jorge Gomes',1,GETDATE(),0),
('josue.evangelista@consultant.volvo.com','Josué Evangelista',2,GETDATE(),0),
('karin.noda@volvo.com','Noda Karin',4,GETDATE(),0),
('tatiane.leonardelli@volvo.com','Leonardelli Tatiane',3,GETDATE(),0),
('thiago.buchweitz@volvo.com','Thiago Buchweitz',1,GETDATE(),0),
('eugenioguanwen.ng@volvo.com','Eugenio Guanwen Ng',1,GETDATE(),0);


--AFTER IMPORTING INVOICES
UPDATE i
SET InvoiceTypeId = it.Id
FROM dbo.Invoices i 
INNER JOIN dbo.InvoiceTypes it
on i.InvoiceTypeName = it.Name
