-- Beszúrások --
  -- Szülõk
INSERT INTO [dbo].[Parents]([name],[birth_day])
VALUES('Szulo1','1999-11-11');

INSERT INTO [dbo].[Parents]([name],[birth_day])
VALUES('Szulo2','1999-11-11');

INSERT INTO [dbo].[Parents]([name],[birth_day])
VALUES('Szulo3','1999-11-11');


  -- Munkahelyek
INSERT INTO [dbo].[Jobs]([workplace_name],[job],[description])
VALUES('EKE','Demonstrátor','A hallgatók oktatása');

INSERT INTO [dbo].[Jobs]([workplace_name],[job],[description])
VALUES('EKE','Tanár','A hallgatók oktatása');

  -- Személyek
INSERT INTO [dbo].[Persons]([name],[birth_day],[job_id])
VALUES('Danisovszky Márk Richárd','1997-11-26',1);

INSERT INTO [dbo].[Persons]([name],[birth_day],[job_id])
VALUES('Munkás2','1999-11-11',2);

  -- Hobbik
INSERT INTO [dbo].[Hobbies]([description])
VALUES('Programozás');

INSERT INTO [dbo].[Hobbies]([description])
VALUES('Gördeszkázás');

  -- Személy_Hobbi
INSERT INTO [dbo].[Person_Hobby]([person_id], [hobby_id])
VALUES(1, 1);

INSERT INTO [dbo].[Person_Hobby]([person_id], [hobby_id])
VALUES(1, 2);

  -- Kisállatok
INSERT INTO [dbo].[Pets]([species], [name])
VALUES('Tengerimalac', 'Bogyó');

  -- Felhasználók (KÓDOLNI KELL MÉG)
INSERT INTO [dbo].[Users]([username], [password])
VALUES('admin', 'admin');

  -- Autók
INSERT INTO [dbo].[Cars]([licence_plate], [manufacurer], [model], [color], [person_id])
VALUES('Mark-21','Audi', 'TT','Fehér',1);

  -- Személy_Állat
INSERT INTO [dbo].[Person_Pet]
VALUES(1, 1);

  -- Személy_Szülõ
INSERT INTO [dbo].[Person_Parent]
VALUES(1, 1);

INSERT INTO [dbo].[Person_Parent]
VALUES(2, 2);