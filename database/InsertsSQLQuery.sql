-- Besz�r�sok --
  -- Sz�l�k
INSERT INTO [dbo].[Parents]([name],[birth_day])
VALUES('Szulo1','1999-11-11');

INSERT INTO [dbo].[Parents]([name],[birth_day])
VALUES('Szulo2','1999-11-11');

INSERT INTO [dbo].[Parents]([name],[birth_day])
VALUES('Szulo3','1999-11-11');


  -- Munkahelyek
INSERT INTO [dbo].[Jobs]([workplace_name],[job],[description])
VALUES('EKE','Demonstr�tor','A hallgat�k oktat�sa');

INSERT INTO [dbo].[Jobs]([workplace_name],[job],[description])
VALUES('EKE','Tan�r','A hallgat�k oktat�sa');

  -- Szem�lyek
INSERT INTO [dbo].[Persons]([name],[birth_day],[job_id])
VALUES('Danisovszky M�rk Rich�rd','1997-11-26',1);

INSERT INTO [dbo].[Persons]([name],[birth_day],[job_id])
VALUES('Munk�s2','1999-11-11',2);

  -- Hobbik
INSERT INTO [dbo].[Hobbies]([description])
VALUES('Programoz�s');

INSERT INTO [dbo].[Hobbies]([description])
VALUES('G�rdeszk�z�s');

  -- Szem�ly_Hobbi
INSERT INTO [dbo].[Person_Hobby]([person_id], [hobby_id])
VALUES(1, 1);

INSERT INTO [dbo].[Person_Hobby]([person_id], [hobby_id])
VALUES(1, 2);

  -- Kis�llatok
INSERT INTO [dbo].[Pets]([species], [name])
VALUES('Tengerimalac', 'Bogy�');

  -- Felhaszn�l�k
INSERT INTO [dbo].[Users]([username], [password])
VALUES('admin','33354741122871651676713774147412831195')

INSERT INTO [dbo].[Users]([username], [password])
VALUES('mark','23413065121221531451291079423823522514922610')

INSERT INTO [dbo].[Users]([username], [password])
VALUES('test','91431072057033211115202222781313839180246')

  -- Aut�k
INSERT INTO [dbo].[Cars]([licence_plate], [manufacurer], [model], [color], [person_id])
VALUES('Mark-21','Audi', 'TT','Feh�r',1);

  -- Szem�ly_�llat
INSERT INTO [dbo].[Person_Pet]
VALUES(1, 1);

  -- Szem�ly_Sz�l�
INSERT INTO [dbo].[Person_Parent]
VALUES(1, 1);

INSERT INTO [dbo].[Person_Parent]
VALUES(2, 2);

  -- M�dos�t�s
INSERT INTO [dbo].[Refresh](last_modify_time)
VALUES('20190531 10:10:10 AM');