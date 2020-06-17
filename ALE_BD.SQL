
CREATE DATABASE BBLLGSB
/*Cr�ation de la base de donn�es BBLLGSB */

GO

USE BBLLGSB
/*Utilisation de la base de donn�es BBLLGSB*/ 


/* -----------------------------------------------------------------------------
      TABLE : VISITEUR
----------------------------------------------------------------------------- */

CREATE TABLE VISITEUR
(
     VIS_MATRICULE CHAR(4),
     VIS_NOM VARCHAR(25) ,
     VIS_PRENOM VARCHAR(50),
     VIS_ADRESSE VARCHAR(50)  ,
     VIS_CP CHAR(5) ,
     VIS_VILLE VARCHAR(30) ,
     VIS_DATEEMBAUCHE DATE,
	 CONSTRAINT PK_VISITEUR PRIMARY KEY (VIS_MATRICULE),
	
)


/* -----------------------------------------------------------------------------
      TABLE : TYPE_PRATICIEN
----------------------------------------------------------------------------- */

CREATE TABLE TYPE_PRATICIEN
(
     TYP_CODE CHAR(3),
     TYP_LIBELLE VARCHAR(25) ,
     TYP_LIEU VARCHAR(35), 
	 CONSTRAINT PK_TYPE_PRATICIEN PRIMARY KEY (TYP_CODE)
)

/* -----------------------------------------------------------------------------
      TABLE : FAMILLE 
-------------------------*/
CREATE TABLE FAMILLE
(
     FAM_CODE varchar(10)  not null  ,
     FAM_LIBELLE varchar(50)not null ,
     CONSTRAINT PK_FAMILLE PRIMARY KEY (FAM_CODE)
)

/* -----------------------------------------------------------------------------
      TABLE : PRATICIEN 
----------------------------------------------------------------------------- */

CREATE TABLE PRATICIEN
(
     PRA_NUM INT IDENTITY (1,1),
     PRA_NOM VARCHAR(25) ,
     PRA_PRENOM VARCHAR(30) ,
     PRA_ADRESSE VARCHAR(255) ,
     PRA_CP CHAR(5) ,
     PRA_VILLE VARCHAR(25) ,
     TYP_CODE CHAR(3),
	 CONSTRAINT PK_PRATICIEN PRIMARY KEY (PRA_NUM),
	 CONSTRAINT FK_PRATICIEN_TYPE_PRATICIEN FOREIGN KEY (TYP_CODE)REFERENCES TYPE_PRATICIEN (TYP_CODE)	 
)


/* -----------------------------------------------------------------------------
      TABLE : MEDICAMENT 
----------------------------------------------------------------------------- */
CREATE TABLE MEDICAMENT
(
     MED_DEPOTLEGAL varchar(50)  not null  ,
     MED_NOMCOMMERCIAL varchar(50)  not null  ,
     FAM_CODE  varchar(10) not null  ,
     MED_COMPOSITION varchar(100)  not null  ,
     MED_EFFETS varchar(255)  not null  ,
     MED_CONTREINDIC varchar(255)  not null,  
     CONSTRAINT PK_MEDICAMENT PRIMARY KEY (MED_DEPOTLEGAL),
	 CONSTRAINT FK_MEDICAMENT_FAMILLE FOREIGN KEY (FAM_CODE)REFERENCES FAMILLE (FAM_CODE)	
	 )

	 

/* -----------------------------------------------------------------------------
      TABLE : RAPPORT_VISITE 
----------------------------------------------------------------------------- */

CREATE TABLE RAPPORT_VISITE
(
     RAP_NUM INT IDENTITY (1,1),
	 VIS_MATRICULE CHAR(4)  not null  ,
     PRA_NUM int  not null  ,
     RAP_DATE DATE not null  ,
     RAP_BILAN varchar(255)  not null  ,
     RAP_MOTIF varchar(255)  not null,
     CONSTRAINT PK_RAPPORT_VISITE PRIMARY KEY (RAP_NUM),  
     CONSTRAINT FK_RAPPORT_VISITE_VISITEUR FOREIGN KEY(VIS_MATRICULE) REFERENCES VISITEUR(VIS_MATRICULE), 
     CONSTRAINT FK_RAPPORT_VISITE_PRATICIEN FOREIGN KEY (PRA_NUM)REFERENCES PRATICIEN (PRA_NUM)
)

/* -----------------------------------------------------------------------------
      TABLE : OFFRIR 
----------------------------------------------------------------------------- */

CREATE TABLE OFFRIR
(           
     RAP_NUM INT  not null  ,
     MED_DEPOTLEGAL varchar(50)  not null  ,
     OFF_QTE INT not null,
     CONSTRAINT PK_OFFRIR PRIMARY KEY ( RAP_NUM,MED_DEPOTLEGAL),
     CONSTRAINT FK_OFFRIR_RAPPORT_VISITE FOREIGN KEY ( RAP_NUM)  REFERENCES RAPPORT_VISITE (RAP_NUM),
     CONSTRAINT FK_OFFRIR_MEDICAMENT FOREIGN KEY ( MED_DEPOTLEGAL)  REFERENCES MEDICAMENT ( MED_DEPOTLEGAL)
)

GO

/* insertion dans la base */

/* Insetion VISITEUR */ 
INSERT INTO VISITEUR (VIS_MATRICULE,VIS_NOM,Vis_PRENOM,VIS_ADRESSE,VIS_CP,VIS_VILLE,VIS_DATEEMBAUCHE) 
VALUES ('V001','Villechalane','Louis','8 cours Lafontaine','29000','BREST','11/12/2018')
INSERT INTO VISITEUR (VIS_MATRICULE,VIS_NOM,Vis_PRENOM,VIS_ADRESSE,VIS_CP,VIS_VILLE,VIS_DATEEMBAUCHE)
 VALUES ('V002','Andre','David','1 r Aimon de Chiss�e','38100','GRENOBLE','26/08/2019')
INSERT INTO VISITEUR (VIS_MATRICULE,VIS_NOM,Vis_PRENOM,VIS_ADRESSE,VIS_CP,VIS_VILLE,VIS_DATEEMBAUCHE)
 VALUES ('V003','Bedos','Christian','1 r B�n�dictins','65000','TARBES','17/07/2017')
INSERT INTO VISITEUR (VIS_MATRICULE,VIS_NOM,Vis_PRENOM,VIS_ADRESSE,VIS_CP,VIS_VILLE,VIS_DATEEMBAUCHE)
 VALUES ('V004','Tusseau','Louis','22 r Renou','86000','POITIERS','02/01/2017')
INSERT INTO VISITEUR (VIS_MATRICULE,VIS_NOM,Vis_PRENOM,VIS_ADRESSE,VIS_CP,VIS_VILLE,VIS_DATEEMBAUCHE)
 VALUES ('V005','Bentot','Pascal','11 av 6 Juin','67000','STRASBOURG','11/03/2010')
INSERT INTO VISITEUR (VIS_MATRICULE,VIS_NOM,Vis_PRENOM,VIS_ADRESSE,VIS_CP,VIS_VILLE,VIS_DATEEMBAUCHE)
 VALUES ('V006','Bioret','Luc','1 r Linne','35000','RENNES','21/03/2014')
INSERT INTO VISITEUR (VIS_MATRICULE,VIS_NOM,Vis_PRENOM,VIS_ADRESSE,VIS_CP,VIS_VILLE,VIS_DATEEMBAUCHE)
 VALUES ('V007','Bunisset','Francis','10 r Nicolas Chorier','85000','LA ROCHE SUR YON','31/01/2009')
INSERT INTO VISITEUR (VIS_MATRICULE,VIS_NOM,Vis_PRENOM,VIS_ADRESSE,VIS_CP,VIS_VILLE,VIS_DATEEMBAUCHE)
 VALUES ('V008','Bunisset','Denise','1 r Lionne','49100','ANGERS','03/07/2014')
INSERT INTO VISITEUR (VIS_MATRICULE,VIS_NOM,Vis_PRENOM,VIS_ADRESSE,VIS_CP,VIS_VILLE,VIS_DATEEMBAUCHE)
 VALUES ('V009','Cacheux','Bernard','114 r Authie','34000','MONTPELLIER','02/08/2009')
INSERT INTO VISITEUR (VIS_MATRICULE,VIS_NOM,Vis_PRENOM,VIS_ADRESSE,VIS_CP,VIS_VILLE,VIS_DATEEMBAUCHE)
 VALUES ('V010','Cadic','Eric','123 r Caponi�re','41000','BLOIS','06/01/2015')
INSERT INTO VISITEUR (VIS_MATRICULE,VIS_NOM,Vis_PRENOM,VIS_ADRESSE,VIS_CP,VIS_VILLE,VIS_DATEEMBAUCHE)
 VALUES ('V011','Charoze','Catherine','100 pl G�ants','33000','BORDEAUX','06/01/2015')
INSERT INTO VISITEUR (VIS_MATRICULE,VIS_NOM,Vis_PRENOM,VIS_ADRESSE,VIS_CP,VIS_VILLE,VIS_DATEEMBAUCHE)
 VALUES ('V012','Clepkens','Christophe','12 r F�d�rico Garcia Lorca','13000','MARSEILLE','06/01/2018')
INSERT INTO VISITEUR (VIS_MATRICULE,VIS_NOM,Vis_PRENOM,VIS_ADRESSE,VIS_CP,VIS_VILLE,VIS_DATEEMBAUCHE)
 VALUES ('V013','Cottin','Vincenne','36 sq Capucins','05000','GAP','06/01/2018')
INSERT INTO VISITEUR (VIS_MATRICULE,VIS_NOM,Vis_PRENOM,VIS_ADRESSE,VIS_CP,VIS_VILLE,VIS_DATEEMBAUCHE)
 VALUES ('V014','Daburon','Fran�ois','13 r Champs Elys�es','06000','NICE','01/02/2009')
INSERT INTO VISITEUR (VIS_MATRICULE,VIS_NOM,Vis_PRENOM,VIS_ADRESSE,VIS_CP,VIS_VILLE,VIS_DATEEMBAUCHE) 
VALUES ('V015','De','Philippe','13 r Charles Peguy','10000','TROYES','05/05/2018')
INSERT INTO VISITEUR (VIS_MATRICULE,VIS_NOM,Vis_PRENOM,VIS_ADRESSE,VIS_CP,VIS_VILLE,VIS_DATEEMBAUCHE) 
VALUES ('V016','Debelle','Michel','181 r Caponi�re','88000','EPINAL','09/04/2001')
INSERT INTO VISITEUR (VIS_MATRICULE,VIS_NOM,Vis_PRENOM,VIS_ADRESSE,VIS_CP,VIS_VILLE,VIS_DATEEMBAUCHE) 
VALUES ('V017','Debelle','Jeanne','134 r Stalingrad','44000','NANTES','05/12/2005')
INSERT INTO VISITEUR (VIS_MATRICULE,VIS_NOM,Vis_PRENOM,VIS_ADRESSE,VIS_CP,VIS_VILLE,VIS_DATEEMBAUCHE) 
VALUES ('V018','Debroise','Michel','2 av 6 Juin','70000','VESOUL','18/11/2005')
INSERT INTO VISITEUR (VIS_MATRICULE,VIS_NOM,Vis_PRENOM,VIS_ADRESSE,VIS_CP,VIS_VILLE,VIS_DATEEMBAUCHE) 
VALUES ('V019','Desmarquest','Nathalie','14 r F�d�rico Garcia Lorca','54000','NANCY','24/03/2003')
INSERT INTO VISITEUR (VIS_MATRICULE,VIS_NOM,Vis_PRENOM,VIS_ADRESSE,VIS_CP,VIS_VILLE,VIS_DATEEMBAUCHE) 
VALUES ('V020','Desnost','Pierre','16 r Barral de Montferrat','55000','VERDUN','17/05/2003')
INSERT INTO VISITEUR (VIS_MATRICULE,VIS_NOM,Vis_PRENOM,VIS_ADRESSE,VIS_CP,VIS_VILLE,VIS_DATEEMBAUCHE) 
VALUES ('V021','Dudouit','Fr�d�ric','18 quai Xavier Jouvin','75000','PARIS','26/04/2008')
INSERT INTO VISITEUR (VIS_MATRICULE,VIS_NOM,Vis_PRENOM,VIS_ADRESSE,VIS_CP,VIS_VILLE,VIS_DATEEMBAUCHE) 
VALUES ('V022','Duncombe','Claude','19 av Alsace Lorraine','09000','FOIX','19/02/2006')
INSERT INTO VISITEUR (VIS_MATRICULE,VIS_NOM,Vis_PRENOM,VIS_ADRESSE,VIS_CP,VIS_VILLE,VIS_DATEEMBAUCHE) 
VALUES ('V023','Enault-Pascreau','C�line','25B r Stalingrad','40000','MONT DE MARSAN','27/11/2010')
INSERT INTO VISITEUR (VIS_MATRICULE,VIS_NOM,Vis_PRENOM,VIS_ADRESSE,VIS_CP,VIS_VILLE,VIS_DATEEMBAUCHE) 
VALUES ('V024','Eynde','Val�rie','3 r Henri Moissan','76000','ROUEN','31/10/2010')
INSERT INTO VISITEUR (VIS_MATRICULE,VIS_NOM,Vis_PRENOM,VIS_ADRESSE,VIS_CP,VIS_VILLE,VIS_DATEEMBAUCHE) 
VALUES ('V025','Finck','Jacques','rte Montreuil Bellay','74000','ANNECY','08/06/2012')
INSERT INTO VISITEUR (VIS_MATRICULE,VIS_NOM,Vis_PRENOM,VIS_ADRESSE,VIS_CP,VIS_VILLE,VIS_DATEEMBAUCHE) 
VALUES ('V026','Fr�mont','Fernande','4 r Jean Giono','69000','LYON','15/02/2012')
INSERT INTO VISITEUR (VIS_MATRICULE,VIS_NOM,Vis_PRENOM,VIS_ADRESSE,VIS_CP,VIS_VILLE,VIS_DATEEMBAUCHE) 
VALUES ('V027','Gest','Alain','30 r Authie','46000','FIGEAC','03/05/2009')
INSERT INTO VISITEUR (VIS_MATRICULE,VIS_NOM,Vis_PRENOM,VIS_ADRESSE,VIS_CP,VIS_VILLE,VIS_DATEEMBAUCHE) 
VALUES ('V028','Gheysen','Galassus','32 bd Mar Foch','75000','PARIS','18/01/2009')
INSERT INTO VISITEUR (VIS_MATRICULE,VIS_NOM,Vis_PRENOM,VIS_ADRESSE,VIS_CP,VIS_VILLE,VIS_DATEEMBAUCHE) 
VALUES ('V029','Girard','Yvon','31 av 6 Juin','80000','AMIENS','27/03/2009')
INSERT INTO VISITEUR (VIS_MATRICULE,VIS_NOM,Vis_PRENOM,VIS_ADRESSE,VIS_CP,VIS_VILLE,VIS_DATEEMBAUCHE) 
VALUES ('V030','Gombert','Luc','32 r Emile Gueymard','56000','VANNES','02/10/2010')


/* Insertion TYPE_PRATICIEN */
INSERT INTO  TYPE_PRATICIEN (TYP_CODE,TYP_LIBELLE,TYP_LIEU) VALUES ('MH','M�decin Hospitalier','Hopital ou clinique')
INSERT INTO  TYPE_PRATICIEN (TYP_CODE,TYP_LIBELLE,TYP_LIEU) VALUES ('MV','M�decine de Ville','Cabinet')
INSERT INTO  TYPE_PRATICIEN (TYP_CODE,TYP_LIBELLE,TYP_LIEU) VALUES ('PH','Pharmacien Hospitalier','Hopital ou clinique')
INSERT INTO  TYPE_PRATICIEN (TYP_CODE,TYP_LIBELLE,TYP_LIEU) VALUES ('PO','Pharmacien Officine','Pharmacie')
INSERT INTO  TYPE_PRATICIEN (TYP_CODE,TYP_LIBELLE,TYP_LIEU) VALUES ('PS','Personnel de sant�','Centre param�dical')

 
/* Insertion PRATICIEN */
INSERT INTO PRATICIEN (PRA_NOM,PRA_PRENOM,PRA_ADRESSE,PRA_CP,PRA_VILLE,TYP_CODE) 
VALUES ('Notini','Alain','114 r Authie','85000','LA ROCHE SUR YON','MH')
INSERT INTO PRATICIEN (PRA_NOM,PRA_PRENOM,PRA_ADRESSE,PRA_CP,PRA_VILLE,TYP_CODE) 
VALUES ('Gosselin','Albert','13 r Devon','41000','BLOIS','MV')
INSERT INTO PRATICIEN (PRA_NOM,PRA_PRENOM,PRA_ADRESSE,PRA_CP,PRA_VILLE,TYP_CODE) 
VALUES ('Delahaye','Andr�','36 av 6 Juin','25000','BESANCON','PS')
INSERT INTO PRATICIEN (PRA_NOM,PRA_PRENOM,PRA_ADRESSE,PRA_CP,PRA_VILLE,TYP_CODE) 
VALUES ('Leroux','Andr�','47 av Robert Schuman','60000','BEAUVAIS','PH')
INSERT INTO PRATICIEN (PRA_NOM,PRA_PRENOM,PRA_ADRESSE,PRA_CP,PRA_VILLE,TYP_CODE) 
VALUES ('Desmoulins','Anne','31 r St Jean','30000','NIMES','PO')
INSERT INTO PRATICIEN (PRA_NOM,PRA_PRENOM,PRA_ADRESSE,PRA_CP,PRA_VILLE,TYP_CODE) 
VALUES ('Mouel','Anne','27 r Auvergne','80000','AMIENS','MH')
INSERT INTO PRATICIEN (PRA_NOM,PRA_PRENOM,PRA_ADRESSE,PRA_CP,PRA_VILLE,TYP_CODE) 
VALUES ('Desgranges-Lentz','Antoine','1 r Albert de Mun','29000','MORLAIX','MV')
INSERT INTO PRATICIEN (PRA_NOM,PRA_PRENOM,PRA_ADRESSE,PRA_CP,PRA_VILLE,TYP_CODE) 
VALUES ('Marcouiller','Arnaud','31 r St Jean','68000','MULHOUSE','PS')
INSERT INTO PRATICIEN (PRA_NOM,PRA_PRENOM,PRA_ADRESSE,PRA_CP,PRA_VILLE,TYP_CODE) 
VALUES ('Dupuy','Benoit','9 r Demolombe','34000','MONTPELLIER','PH')
INSERT INTO PRATICIEN (PRA_NOM,PRA_PRENOM,PRA_ADRESSE,PRA_CP,PRA_VILLE,TYP_CODE) 
VALUES ('Lerat','Bernard','31 r St Jean','59000','LILLE','PO')
INSERT INTO PRATICIEN (PRA_NOM,PRA_PRENOM,PRA_ADRESSE,PRA_CP,PRA_VILLE,TYP_CODE) 
VALUES ('Mar�ais-Lefebvre','Bertrand','86Bis r Basse','67000','STRASBOURG','MH')
INSERT INTO PRATICIEN (PRA_NOM,PRA_PRENOM,PRA_ADRESSE,PRA_CP,PRA_VILLE,TYP_CODE) 
VALUES ('Boscher','Bruno','94 r Falaise','10000','TROYES','MV')
INSERT INTO PRATICIEN (PRA_NOM,PRA_PRENOM,PRA_ADRESSE,PRA_CP,PRA_VILLE,TYP_CODE) 
VALUES ('Morel','Catherine','21 r Chateaubriand','75000','PARIS','PS')
INSERT INTO PRATICIEN (PRA_NOM,PRA_PRENOM,PRA_ADRESSE,PRA_CP,PRA_VILLE,TYP_CODE) 
VALUES ('Guivarch','Chantal','4 av G�n Laperrine','45000','ORLEANS','PH')
INSERT INTO PRATICIEN (PRA_NOM,PRA_PRENOM,PRA_ADRESSE,PRA_CP,PRA_VILLE,TYP_CODE) 
VALUES ('Bessin-Grosdoit','Christophe','92 r Falaise','06000','NICE','PO')
INSERT INTO PRATICIEN (PRA_NOM,PRA_PRENOM,PRA_ADRESSE,PRA_CP,PRA_VILLE,TYP_CODE) 
VALUES ('Rossa','Claire','14 av Thi�s','6000','NICE','MH')
INSERT INTO PRATICIEN (PRA_NOM,PRA_PRENOM,PRA_ADRESSE,PRA_CP,PRA_VILLE,TYP_CODE) 
VALUES ('Cauchy','Denis','5 av Ste Th�r�se','11000','NARBONNE','MV')
INSERT INTO PRATICIEN (PRA_NOM,PRA_PRENOM,PRA_ADRESSE,PRA_CP,PRA_VILLE,TYP_CODE) 
VALUES ('Gaff�','Dominique','9 av 1�re Arm�e Fran�aise','35000','RENNES','PS')
INSERT INTO PRATICIEN (PRA_NOM,PRA_PRENOM,PRA_ADRESSE,PRA_CP,PRA_VILLE,TYP_CODE) 
VALUES ('Guenon','Dominique','98 bd Mar Lyautey','44000','NANTES','PH')
INSERT INTO PRATICIEN (PRA_NOM,PRA_PRENOM,PRA_ADRESSE,PRA_CP,PRA_VILLE,TYP_CODE) 
VALUES ('Pr�vot','Dominique','29 r Lucien Nelle','87000','LIMOGES','PO')
INSERT INTO PRATICIEN (PRA_NOM,PRA_PRENOM,PRA_ADRESSE,PRA_CP,PRA_VILLE,TYP_CODE) 
VALUES ('Houchard','Eliane','9 r Demolombe','49100','ANGERS','MH')
INSERT INTO PRATICIEN (PRA_NOM,PRA_PRENOM,PRA_ADRESSE,PRA_CP,PRA_VILLE,TYP_CODE) 
VALUES ('Desmons','Elisabeth','51 r Berni�res','29000','QUIMPER','MV')
INSERT INTO PRATICIEN (PRA_NOM,PRA_PRENOM,PRA_ADRESSE,PRA_CP,PRA_VILLE,TYP_CODE) 
VALUES ('Flament','Elisabeth','11 r Pasteur','35000','RENNES','PS')
INSERT INTO PRATICIEN (PRA_NOM,PRA_PRENOM,PRA_ADRESSE,PRA_CP,PRA_VILLE,TYP_CODE) 
VALUES ('Goussard','Emmanuel','9 r Demolombe','41000','BLOIS','PH')
INSERT INTO PRATICIEN (PRA_NOM,PRA_PRENOM,PRA_ADRESSE,PRA_CP,PRA_VILLE,TYP_CODE) 
VALUES ('Desprez','Eric','9 r Vaucelles','33000','BORDEAUX','PO')
INSERT INTO PRATICIEN (PRA_NOM,PRA_PRENOM,PRA_ADRESSE,PRA_CP,PRA_VILLE,TYP_CODE) 
VALUES ('Coste','Evelyne','29 r Lucien Nelle','19000','TULLE','MH')
INSERT INTO PRATICIEN (PRA_NOM,PRA_PRENOM,PRA_ADRESSE,PRA_CP,PRA_VILLE,TYP_CODE) 
VALUES ('Lefebvre','Fr�d�ric','2 pl Wurzburg','55000','VERDUN','MV')
INSERT INTO PRATICIEN (PRA_NOM,PRA_PRENOM,PRA_ADRESSE,PRA_CP,PRA_VILLE,TYP_CODE) 
VALUES ('Lem�e','Fr�d�ric','29 av 6 Juin','56000','VANNES','PS')
INSERT INTO PRATICIEN (PRA_NOM,PRA_PRENOM,PRA_ADRESSE,PRA_CP,PRA_VILLE,TYP_CODE) 
VALUES ('Martin','Fr�d�ric','B�t A 90 r Bayeux','70000','VESOUL','PH')
INSERT INTO PRATICIEN (PRA_NOM,PRA_PRENOM,PRA_ADRESSE,PRA_CP,PRA_VILLE,TYP_CODE) 
VALUES ('Marie','Fr�d�rique','172 r Caponi�re','70000','VESOUL','PO')


  
/* Insertion FAMILLE */ 
INSERT INTO FAMILLE (FAM_CODE,FAM_LIBELLE) VALUES ('AA', 'Antalgiques en association')
INSERT INTO FAMILLE (FAM_CODE,FAM_LIBELLE) VALUES ('AAA', 'Antalgiques antipyr�ques en association')
INSERT INTO FAMILLE (FAM_CODE,FAM_LIBELLE) VALUES ('AAC', 'Antid�presseur d action centrale')
INSERT INTO FAMILLE (FAM_CODE,FAM_LIBELLE) VALUES ('AAH', 'Antivertigineux antihistaminique H1')
INSERT INTO FAMILLE (FAM_CODE,FAM_LIBELLE) VALUES ('ABA', 'Antibiotique antituberculeux')
INSERT INTO FAMILLE (FAM_CODE,FAM_LIBELLE) VALUES ('ABC', 'Antibiotique antiacn�nique local')
INSERT INTO FAMILLE (FAM_CODE,FAM_LIBELLE) VALUES ('ABP', 'Antibiotique de la famille des b�ta-lactamines')
INSERT INTO FAMILLE (FAM_CODE,FAM_LIBELLE) VALUES ('AFC', 'Antibiotique de la famille des cyclines')
INSERT INTO FAMILLE (FAM_CODE,FAM_LIBELLE) VALUES ('AFM', 'Antibiotique de la famille des macrolides')
INSERT INTO FAMILLE (FAM_CODE,FAM_LIBELLE) VALUES ('AH', 'Antihistaminique H1 local')
INSERT INTO FAMILLE (FAM_CODE,FAM_LIBELLE) VALUES ('AIM', 'Antid�presseur imipraminique -tricyclique-')
INSERT INTO FAMILLE (FAM_CODE,FAM_LIBELLE) VALUES ('AIN', 'Antid�presseur inhibiteur s�lectif')
INSERT INTO FAMILLE (FAM_CODE,FAM_LIBELLE) VALUES ('ALO', 'Antibiotique local -ORL-')
INSERT INTO FAMILLE (FAM_CODE,FAM_LIBELLE) VALUES ('ANS', 'Antid�presseur IMAO non s�lectif')
INSERT INTO FAMILLE (FAM_CODE,FAM_LIBELLE) VALUES ('AO', 'Antibiotique ophtalmique')
INSERT INTO FAMILLE (FAM_CODE,FAM_LIBELLE) VALUES ('AP', 'Antipsychotique normothymique')
INSERT INTO FAMILLE (FAM_CODE,FAM_LIBELLE) VALUES ('AUM', 'Antibiotique urinaire minute')
INSERT INTO FAMILLE (FAM_CODE,FAM_LIBELLE) VALUES ('CRT', 'Corticoide,antibiotique,antifongique � usage local')
INSERT INTO FAMILLE (FAM_CODE,FAM_LIBELLE) VALUES ('HYP', 'Hypnotique antihistaminique')
INSERT INTO FAMILLE (FAM_CODE,FAM_LIBELLE) VALUES ('PSA', 'Psychostimulant antiasth�sique')

/* Insertion MEDICAMENT */
INSERT INTO MEDICAMENT(MED_DEPOTLEGAL,MED_NOMCOMMERCIAL,FAM_CODE,MED_COMPOSITION,MED_EFFETS,MED_CONTREINDIC)         
    VALUES
			('3MYC7', 
			'TRIMYCINE',
			'CRT', 
			'Triamcinolone ac�tonide + N�omycine + Nystatine',
			'Ce m�dicament est un cortico�de � activit� forte ou tr�s forte associ� � un antibiotique',
			'Ce m�dicament est contre-indiqu� en cas d allergie � l un des constituants  d infections de la peau'
			)     

INSERT INTO MEDICAMENT(MED_DEPOTLEGAL,MED_NOMCOMMERCIAL,FAM_CODE,MED_COMPOSITION,MED_EFFETS,MED_CONTREINDIC)         
    VALUES
			('ADIMOL9',
			'ADIMOL',
			'ABP',
			'Amoxicilline + Acide',
			'Ce m�dicament, plus puissant que les p�nicillines simples, est utilis� pour traiter des infections bact�riennes sp�cifiques.',
			'Ce m�dicament est contre-indiqu� en cas d''allergie aux p�nicillines ou aux c�phalosporines.' 
			)

INSERT INTO MEDICAMENT(MED_DEPOTLEGAL,MED_NOMCOMMERCIAL,FAM_CODE,MED_COMPOSITION,MED_EFFETS,MED_CONTREINDIC)         
    VALUES	
			('AMOPIL7',
			'AMOPIL',
			'ABP',
			'Amoxicilline ',
			'Ce m�dicament, plus puissant que les p�nicillines simples, est utilis� pour traiter des infections bact�riennes sp�cifiques.',
			'Ce m�dicament est contre-indiqu� en cas d''allergie aux p�nicillines. Il doit �tre administr� avec prudence en cas d''allergie aux c�phalosporines.' 
			)
INSERT INTO MEDICAMENT(MED_DEPOTLEGAL,MED_NOMCOMMERCIAL,FAM_CODE,MED_COMPOSITION,MED_EFFETS,MED_CONTREINDIC)         
    VALUES
			('AMOX45',
			'AMOXAR',
			'ABP',
			'Amoxicilline',
			'Ce m�dicament, plus puissant que les p�nicillines simples, est utilis� pour traiter des infections bact�riennes sp�cifiques.',
			'La prise de ce m�dicament peut rendre positifs les tests de d�pistage du dopage.    '
			)
INSERT INTO MEDICAMENT(MED_DEPOTLEGAL,MED_NOMCOMMERCIAL,FAM_CODE,MED_COMPOSITION,MED_EFFETS,MED_CONTREINDIC)         
    VALUES
		(	'AMOXIG12',
			'AMOXI G�',
			'ABP',
			'Amoxicilline',
			'Ce m�dicament, plus puissant que les p�nicillines simples, est utilis� pour traiter des infections bact�riennes sp�cifiques.',
			'Ce m�dicament est contre-indiqu� en cas d''allergie aux p�nicillines. Il doit �tre administr� avec prudence en cas d''allergie aux c�phalosporines.   '
		)
	
INSERT INTO MEDICAMENT(MED_DEPOTLEGAL,MED_NOMCOMMERCIAL,FAM_CODE,MED_COMPOSITION,MED_EFFETS,MED_CONTREINDIC)         
    VALUES
			('APATOUX22',
			 'APATOUX Vitamine C',
			 'ALO',
			 'Tyrothricine + T�traca�ne + Acide ascorbique (Vitamine C)',
			 'Ce m�dicament est utilis� pour traiter les affections de la bouche et de la gorge.',
			 'Ce m�dicament est contre-indiqu� en cas d''allergie � l''un des constituants, en cas de ph�nylc�tonurie et chez l''enfant de moins de 6 ans. '
			)
					
INSERT INTO MEDICAMENT(MED_DEPOTLEGAL,MED_NOMCOMMERCIAL,FAM_CODE,MED_COMPOSITION,MED_EFFETS,MED_CONTREINDIC)         
    VALUES
			('BACTIG10',
			'BACTIGEL',
			'ABC',
			'Erythromycine',
			'Ce m�dicament est utilis� en application locale pour traiter l''acn� et les infections cutan�es bact�riennes associ�es.',
			'Ce m�dicament est contre-indiqu� en cas d''allergie aux antibiotiques de la famille des macrolides ou des lincosanides.  '
			)

INSERT INTO MEDICAMENT(MED_DEPOTLEGAL,MED_NOMCOMMERCIAL,FAM_CODE,MED_COMPOSITION,MED_EFFETS,MED_CONTREINDIC)         
    VALUES
			('BACTIV13',
			'BACTIVIL',
			'AFM',
			'Erythromycine',
			'Ce m�dicament est utilis� pour traiter des infections bact�riennes sp�cifiques. ',
			'Ce m�dicament est contre-indiqu� en cas d''allergie aux macrolides (dont le chef de file est l''�rythromycine). '
			)	
			
INSERT INTO MEDICAMENT(MED_DEPOTLEGAL,MED_NOMCOMMERCIAL,FAM_CODE,MED_COMPOSITION,MED_EFFETS,MED_CONTREINDIC)         
    VALUES			
			('BITALV', 
			'BIVALIC',
			'AAA',
			'Dextropropoxyph�ne + Parac�tamol',
			'Ce m�dicament est utilis� pour traiter les douleurs d''intensit� mod�r�e ou intense. ', 
			'Ce m�dicament est contre-indiqu� en cas d''allergie aux m�dicaments de cette famille, d''insuffisance h�patique ou d''insuffisance r�nale. '
			)
INSERT INTO MEDICAMENT(MED_DEPOTLEGAL,MED_NOMCOMMERCIAL,FAM_CODE,MED_COMPOSITION,MED_EFFETS,MED_CONTREINDIC)         
    VALUES
			('CARTION6', 
			'CARTION',
			'AAA',
			'Acide ac�tylsalicylique (aspirine)+ Acide ascorbique (Vitamine C) + Parac�tamol',
			'Ce m�dicament est utilis� dans le traitement symptomatique de la douleur ou de la fi�vre. ', 
			'Ce m�dicament est contre-indiqu� en cas de troubles de la coagulation (tendances aux h�morragies), d''ulc�re gastroduod�nal, maladies graves du foie. '
			)
			
INSERT INTO MEDICAMENT(MED_DEPOTLEGAL,MED_NOMCOMMERCIAL,FAM_CODE,MED_COMPOSITION,MED_EFFETS,MED_CONTREINDIC)         
    VALUES	
			('CLAZER6', 
			'CLAZER',
			'AFM',
			'Clarithromycine',
			'Ce m�dicament est utilis� pour traiter des infections bact�riennes sp�cifiques. Il est �galement utilis� dans le traitement de l''ulc�re gastro-duod�nal, en association avec d''autres m�dicaments. ', 
			'Ce m�dicament est contre-indiqu� en cas d''allergie aux macrolides (dont le chef de file est l''�rythromycine).'
			)
INSERT INTO MEDICAMENT(MED_DEPOTLEGAL,MED_NOMCOMMERCIAL,FAM_CODE,MED_COMPOSITION,MED_EFFETS,MED_CONTREINDIC)         
    VALUES
			('DEPRIL9', 
			'DEPRAMIL',
			'AIM',
			'Clomipramine',
			'Ce m�dicament est utilis� pour traiter les �pisodes d�pressifs s�v�res, certaines douleurs rebelles, les troubles obsessionnels compulsifs et certaines �nur�sies chez l''enfant.  ',
			'Ce m�dicament est contre-indiqu� en cas de glaucome ou d''ad�nome de la prostate, d''infarctus r�cent, ou si vous avez eu un traitement par IMAO durant les 2 semaines pr�c�dentes ou en cas d''allergie aux antid�presseurs imipraminiques.' 
			)
INSERT INTO MEDICAMENT(MED_DEPOTLEGAL,MED_NOMCOMMERCIAL,FAM_CODE,MED_COMPOSITION,MED_EFFETS,MED_CONTREINDIC)         
    VALUES			
			('DIMIRTAM6', 
			'DIMIRTAM',
			'AAC',
			'Mirtazapine',
			'Ce m�dicament est utilis� pour traiter les �pisodes d�pressifs s�v�res.',
			'La prise de ce produit est contre-indiqu�e en cas de d''allergie � l''un des constituants.'
			)	
INSERT INTO MEDICAMENT(MED_DEPOTLEGAL,MED_NOMCOMMERCIAL,FAM_CODE,MED_COMPOSITION,MED_EFFETS,MED_CONTREINDIC)         
    VALUES
			('DOLRIL7', 
			'DOLORIL',
			'AAA',
			'Acide ac�tylsalicylique (aspirine) + Acide ascorbique (Vitamine C) + Parac�tamol',
			'Ce m�dicament est utilis� dans le traitement symptomatique de la douleur ou de la fi�vre.',
			'Ce m�dicament est contre-indiqu� en cas d''allergie au parac�tamol ou aux salicylates.'
			)		
	INSERT INTO MEDICAMENT(MED_DEPOTLEGAL,MED_NOMCOMMERCIAL,FAM_CODE,MED_COMPOSITION,MED_EFFETS,MED_CONTREINDIC)         
    VALUES	
			('DORNOM8', 
			'NORMADOR',
			'HYP',
			'Doxylamine',
			'Ce m�dicament est utilis� pour traiter l''insomnie chez l''adulte.',
			'Ce m�dicament est contre-indiqu� en cas de glaucome, de certains troubles urinaires (r�tention urinaire) et chez l''enfant de moins de 15 ans.'
			)		
	INSERT INTO MEDICAMENT(MED_DEPOTLEGAL,MED_NOMCOMMERCIAL,FAM_CODE,MED_COMPOSITION,MED_EFFETS,MED_CONTREINDIC)         
    VALUES	
			('EQUILARX6', 
			'EQUILAR',
			'AAH',
			'M�clozine',
			'Ce m�dicament est utilis� pour traiter les vertiges et pour pr�venir et pour pr�venir le mal des transports.',
			'Ce m�dicament ne doit pas �tre utilis� en cas d''allergie au produit, en cas de glaucome ou de r�tention urinaire.'
			)
	INSERT INTO MEDICAMENT(MED_DEPOTLEGAL,MED_NOMCOMMERCIAL,FAM_CODE,MED_COMPOSITION,MED_EFFETS,MED_CONTREINDIC)         
    VALUES
			('EVILR7', 
			'EVEILLOR',
			'PSA',
			'Adrafinil',
			'Ce m�dicament est utilis� pour traiter les troubles de la vigilance et certains symptomes neurologiques chez le sujet ag�.',
			'Ce m�dicament est contre-indiqu� en cas d''allergie � l''un des constituants.'
			)
INSERT INTO MEDICAMENT(MED_DEPOTLEGAL,MED_NOMCOMMERCIAL,FAM_CODE,MED_COMPOSITION,MED_EFFETS,MED_CONTREINDIC)         
    VALUES
		('INSXT5', 
		'INSECTIL',
		'AH', 
		'Diph�nydramine',
		'Ce m�dicament est utilis� en application locale sur les piq�res d insecte et l urticaire.', 
		'Ce m�dicament est contre-indiqu� en cas d allergie aux antihistaminiques.'
		)
		
INSERT INTO MEDICAMENT(MED_DEPOTLEGAL,MED_NOMCOMMERCIAL,FAM_CODE,MED_COMPOSITION,MED_EFFETS,MED_CONTREINDIC)         
    VALUES
		('JOVAI8',
		'JOVENIL',
		'AFM', 
		'Josamycine',
		'Ce m�dicament est utilis� pour traiter des infections bact�riennes sp�cifiques.', 
		'Ce m�dicament est contre-indiqu� en cas d allergie aux macrolides '
		)
INSERT INTO MEDICAMENT(MED_DEPOTLEGAL,MED_NOMCOMMERCIAL,FAM_CODE,MED_COMPOSITION,MED_EFFETS,MED_CONTREINDIC)         
    VALUES
		('LIDOXY23', 
		'LIDOXYTRACINE',
		'AFC',
		'Oxyt�tracycline +Lidoca�ne',
		'Ce m�dicament est utilis� en injection intramusculaire pour traiter certaines infections sp�cifiques', 
		'Ce m�dicament est contre-indiqu� en cas d allergie � l un des constituants'
		)
		
INSERT INTO MEDICAMENT(MED_DEPOTLEGAL,MED_NOMCOMMERCIAL,FAM_CODE,MED_COMPOSITION,MED_EFFETS,MED_CONTREINDIC)         
    VALUES
		('LITHOR12',
		'LITHORINE', 
		'AP', 'Lithium',
		'Ce m�dicament est indiqu� dans la pr�vention des psychoses maniaco-d�pressives	',
		'Ce m�dicament ne doit pas �tre utilis� si vous �tes allergique au lithium.'
		)
INSERT INTO MEDICAMENT(MED_DEPOTLEGAL,MED_NOMCOMMERCIAL,FAM_CODE,MED_COMPOSITION,MED_EFFETS,MED_CONTREINDIC)         
    VALUES
		('PARMOL16',
		'PARMOCODEINE',
		'AA', 'Cod�ine + Parac�tamol',
		'Ce m�dicament est utilis� pour le traitement des douleurs lorsque des antalgiques simples ne sont pas efficaces', 
		'Ce m�dicament est contre-indiqu� en cas d allergie � l un des constituants '
		)
		
INSERT INTO MEDICAMENT(MED_DEPOTLEGAL,MED_NOMCOMMERCIAL,FAM_CODE,MED_COMPOSITION,MED_EFFETS,MED_CONTREINDIC)         
    VALUES
		('PHYSOI8',
		'PHYSICOR', 
		'PSA', 'Sulbutiamine',
		'Ce m�dicament est utilis� pour traiter les baisses d activit� physique ou psychique ', 
		'Ce m�dicament est contre-indiqu� en cas d allergie � l un des constituants.'
		)

/* Insertion RAPPORT_VISITE */ 
INSERT INTO  RAPPORT_VISITE (PRA_NUM,VIS_MATRICULE,RAP_DATE,RAP_BILAN,RAP_MOTIF) 
VALUES (23,'V025','18/04/2018','M�decin curieux, � recontacer en d�cembre pour r�union','Actualisation annuelle')
INSERT INTO  RAPPORT_VISITE (PRA_NUM,VIS_MATRICULE,RAP_DATE,RAP_BILAN,RAP_MOTIF) 
VALUES (30,'V025','23/03/2018','RAS Changement de tel : 05 89 89 89 89','Rapport Annuel')
INSERT INTO  RAPPORT_VISITE (PRA_NUM,VIS_MATRICULE,RAP_DATE,RAP_BILAN,RAP_MOTIF) 
VALUES (30,'V026','21/05/2018','Changement de direction, red�finition de la politique m�dicamenteuse, recours au g�n�rique','Baisse activit�')
INSERT INTO  RAPPORT_VISITE (PRA_NUM,VIS_MATRICULE,RAP_DATE,RAP_BILAN,RAP_MOTIF) 
VALUES (30,'V026','13/09/2018','','')
INSERT INTO  RAPPORT_VISITE (PRA_NUM,VIS_MATRICULE,RAP_DATE,RAP_BILAN,RAP_MOTIF) 
VALUES (1,'V001','13/09/2018','','')
INSERT INTO  RAPPORT_VISITE (PRA_NUM,VIS_MATRICULE,RAP_DATE,RAP_BILAN,RAP_MOTIF) 
VALUES (4,'V002' ,'19/01/2019','M�decin curieux, � recontacer en d�cembre pour r�union','Actualisation annuelle')
	
/* Insertion OFFRIR */
INSERT INTO OFFRIR (RAP_NUM,MED_DEPOTLEGAL,OFF_QTE)
     VALUES (1,'3MYC7',3 )
INSERT INTO OFFRIR (RAP_NUM,MED_DEPOTLEGAL,OFF_QTE)
     VALUES (2,'3MYC7',5 )
INSERT INTO OFFRIR (RAP_NUM,MED_DEPOTLEGAL,OFF_QTE)
     VALUES (1,'ADIMOL9',3 )
INSERT INTO OFFRIR (RAP_NUM,MED_DEPOTLEGAL,OFF_QTE)
     VALUES (3,'ADIMOL9',9)
INSERT INTO OFFRIR (RAP_NUM,MED_DEPOTLEGAL,OFF_QTE)
     VALUES (3,'PARMOL16',2 )



/*Cr�ation des proc�dures stock�es pour la fonctionnalit� consultation des comptes rendus*/

GO

CREATE PROC PSS_ListeRapports
/*Cr�ation de la proc�dure stock�e PSS_ListeRapports affichants les informations des rapports*/
AS
/*Selection du num�ro et date de visite du rapport, du nom et prenom du visiteur et du nom et prenom du praticien*/
SELECT RAP_NUM, RAP_DATE, VIS_NOM,VIS_PRENOM, PRA_NOM,PRA_PRENOM
FROM RAPPORT_VISITE as R inner join 
VISITEUR as V on R.VIS_MATRICULE=V.VIS_MATRICULE inner join
PRATICIEN as P on P.PRA_NUM= R.PRA_NUM
/*Tri�e sur la date la visite*/
ORDER BY R.RAP_DATE


GO

CREATE PROC PSS_DateRapports
/*Cr�ation de la proc�dure stock�e PSS_DateRapports affichant la liste des rapports avec la selection d'une date*/
@RAP_DATE DATE
/*param�tre @RAP_DATE de type DATE*/
AS
/*Selection du num�ro et date de visite du rapport, du nom et prenom du visiteur et du nom et prenom du praticien*/
SELECT RAP_NUM, RAP_MOTIF,RAP_BILAN, VIS_NOM,VIS_PRENOM, PRA_NOM,PRA_PRENOM
FROM RAPPORT_VISITE as R inner join 
VISITEUR as V on R.VIS_MATRICULE=V.VIS_MATRICULE inner join
PRATICIEN as P on P.PRA_NUM= R.PRA_NUM
WHERE R.RAP_DATE = @RAP_DATE


GO

CREATE PROC PSS_NombreRapports
/*Cr�ation de la proc�dure stock�e PSS_NombreRapports affichant le nombre de rapports*/
AS
/*S�lection du nombre de rapports*/
SELECT COUNT(*) AS [Nombre de rapports]
FROM RAPPORT_VISITE


GO

CREATE PROC PSD_SuppressionRapport
/*Création de la procédure stockée PSD_SuppressionRapport supprimant un rapport*/
@UnRAPNum int
AS
DELETE FROM RAPPORT_VISITE 
WHERE RAPPORT_VISITE.RAP_NUM = @UnRAPNum
DELETE FROM OFFRIR
WHERE OFFRIR.RAP_NUM = @UnRAPNum

GO

CREATE PROC PSU_MajRapports
/*création de la procédure PSU_MajRapports permettant de mettre à jour un rapports*/
@RAP_NUM INT,
@RAP_MODIF VARCHAR(255),
@RAP_BILAN VARCHAR(255)
/*paramétre modifiable*/
AS
/*update de la table RAPPORT_VISITE*/
UPDATE RAPPORT_VISITE 
SET RAP_MOTIF = @RAP_MODIF,RAP_BILAN = @RAP_BILAN 
WHERE RAP_NUM = @RAP_NUM


GO

CREATE PROC PSS_ListeMajRapports
/*Création de la procédure PSS_ListeMajRapports permettant d'afficher les rapports avec le bilan et le motif pour la modification*/
AS
/*Sélection des éléments pour la liste des rapports*/
SELECT RAP_NUM, RAP_DATE,RAP_BILAN,RAP_MOTIF, VIS_NOM,VIS_PRENOM, PRA_NOM,PRA_PRENOM
FROM RAPPORT_VISITE as R inner join 
VISITEUR as V on R.VIS_MATRICULE=V.VIS_MATRICULE inner join
PRATICIEN as P on P.PRA_NUM= R.PRA_NUM
/*Tri�e sur la date la visite*/
ORDER BY R.RAP_DATE

GO

CREATE PROC PSS_MatriculeVis
AS
/*On selection la liste des visiteurs suivi de leurs nom et prenom*/
SELECT VIS_MATRICULE ,VIS_MATRICULE + ' (' + VIS_NOM + ' ' + VIS_PRENOM + ')' AS 'Matricule des visiteurs'
FROM VISITEUR

GO

CREATE PROC PSS_NumPraticien
AS
/*On selection la liste des praticiens suivi de leurs nom et prenom*/
SELECT PRA_NUM ,str(PRA_NUM) + ' (' + PRA_NOM + ' ' + PRA_PRENOM + ')' AS 'Numero des praticiens'
FROM PRATICIEN

GO 

CREATE PROC PSI_unRapport
@VisMat CHAR(4),
@PraNum int,
@RapBilan varchar(255),
@RapMotif varchar(255),
@MedicVendu varchar(255),
@off_qte int
AS
DECLARE @RAP_NUM VARCHAR(255)
/*On insert les informations recolte en parametre*/
INSERT INTO RAPPORT_VISITE (VIS_MATRICULE, PRA_NUM, RAP_BILAN, RAP_MOTIF, RAP_DATE)
/*On utilise la date du systeme pour la reseigner dans la BD*/
VALUES (@VisMat, @PraNum, @RapBilan, @RapMotif, CAST(SYSDATETIME() as DATE))

SET @RAP_NUM = (SELECT MAX(RAP_NUM) FROM RAPPORT_VISITE)

INSERT INTO OFFRIR (RAP_NUM, MED_DEPOTLEGAL, OFF_QTE)
VALUES (@RAP_NUM, @MedicVendu, @off_qte)

GO


CREATE PROC PSS_ListeMedicament
AS
SELECT MED_DEPOTLEGAL, MED_DEPOTLEGAL + ' (' + MED_NOMCOMMERCIAL + ')' AS 'Numero des médicaments'
FROM MEDICAMENT

SELECT * FROM MEDICAMENT

GO

CREATE PROC PSS_ArchListeRapports
/*Cr�ation de la proc�dure stock�e PSS_ArchListeRapports affichants les informations des rapports*/
AS
/*Selection du num�ro et date de visite du rapport, du nom et prenom du visiteur et du nom et prenom du praticien*/
SELECT ARCHI_RAP_NUM, ARCHI_RAP_DATE, VIS_NOM,VIS_PRENOM, PRA_NOM,PRA_PRENOM
FROM ARCHI_RAPPORT_VISITE as R inner join 
VISITEUR as V on R.ARCHI_VIS_MATRICULE=V.VIS_MATRICULE inner join
PRATICIEN as P on P.PRA_NUM= R.ARCHI_PRA_NUM
/*Tri�e sur la date la visite*/
ORDER BY R.ARCHI_RAP_DATE


GO

CREATE PROC PSS_ArchDateRapports
/*Cr�ation de la proc�dure stock�e PSS_ArchDateRapports affichant la liste des rapports avec la selection d'une date*/
@RAP_DATE DATE
/*param�tre @RAP_DATE de type DATE*/
AS
/*Selection du num�ro et date de visite du rapport, du nom et prenom du visiteur et du nom et prenom du praticien*/
SELECT ARCHI_RAP_NUM, ARCHI_RAP_MOTIF,ARCHI_RAP_BILAN, VIS_NOM,VIS_PRENOM, PRA_NOM,PRA_PRENOM
FROM ARCHI_RAPPORT_VISITE as R inner join 
VISITEUR as V on R.ARCHI_VIS_MATRICULE=V.VIS_MATRICULE inner join
PRATICIEN as P on P.PRA_NUM= R.ARCHI_PRA_NUM
WHERE R.ARCHI_RAP_DATE = @RAP_DATE


GO

CREATE PROC PSS_ArchNombreRapports
/*Cr�ation de la proc�dure stock�e PSS_ArchNombreRapports affichant le nombre de rapports*/
AS
/*S�lection du nombre de rapports*/
SELECT COUNT(*) AS [Nombre de rapports]
FROM ARCHI_RAPPORT_VISITE

GO

CREATE PROC PSS_ListeMedocRap
@RAP_NUM INT
AS
SELECT MEDICAMENT.MED_DEPOTLEGAL, OFF_QTE, MED_NOMCOMMERCIAL, MED_COMPOSITION, MED_EFFETS, MED_CONTREINDIC, FAM_CODE
FROM MEDICAMENT INNER JOIN OFFRIR
ON MEDICAMENT.MED_DEPOTLEGAL = OFFRIR.MED_DEPOTLEGAL
WHERE RAP_NUM = @RAP_NUM

GO

CREATE PROC PSS_ArchListeMedocRap
@RAP_NUM INT
AS
SELECT MEDICAMENT.MED_DEPOTLEGAL, ARCHI_OFF_QTE, MED_NOMCOMMERCIAL, MED_COMPOSITION, MED_EFFETS, MED_CONTREINDIC, FAM_CODE
FROM MEDICAMENT INNER JOIN ARCHI_OFFRIR
ON MEDICAMENT.MED_DEPOTLEGAL = ARCHI_OFFRIR.ARCHI_MED_DEPOTLEGAL
WHERE ARCHI_OFFRIR.ARCHI_RAP_NUM = @RAP_NUM

select * from ARCHI_OFFRIR

/*Création des procédures stockées pour la fonctionnalité consultation des visiteurs*/

GO

CREATE PROC PSS_InfoVisiteur
/*Création de la procédure stockée PSS_InfoVisiteur affichant la liste des informations
du visiteur*/
AS
/*Selection du numéro, du nom, du prénom, de la date d'embauche des visiteurs*/
SELECT VIS_MATRICULE,VIS_NOM,VIS_PRENOM,VIS_DATEEMBAUCHE 
FROM VISITEUR
ORDER BY VIS_NOM, VIS_PRENOM ASC


GO


CREATE PROC PSS_DetailVisiteur
/*Création de la procédure stockée PSS_DetailVisiteur affichant l'adresse du visiteur durant le clique*/
@VIS_MATRICULE CHAR(4)
/*Paramétre qui vas recevoir le matricule du visiteur*/
AS
/*Selection de l'adresse du code postale et de la ville du client*/
SELECT VIS_NOM,VIS_PRENOM, VIS_ADRESSE,VIS_CP,VIS_VILLE, VIS_DATEEMBAUCHE
FROM VISITEUR
WHERE VIS_MATRICULE = @VIS_MATRICULE


GO

CREATE PROC PSS_DetailVisiteurParDate
/*Création de la procédure stockée PSS_DetailVisiteur affichant l'adresse du visiteur durant le clique*/
@VIS_MATRICULE CHAR(4), @VIS_DATE DATE
/*Paramétre qui vas recevoir le matricule du visiteur et la date d'embauche sélectionnée*/
AS
/*Selection de l'adresse du code postale et de la ville du client*/
SELECT VIS_NOM,VIS_PRENOM, VIS_ADRESSE,VIS_CP,VIS_VILLE, VIS_DATEEMBAUCHE
FROM VISITEUR
WHERE VIS_MATRICULE = @VIS_MATRICULE AND VIS_DATEEMBAUCHE = @VIS_DATE


GO

CREATE PROC PSS_DateEmbaucheVisiteur
/*Création de la procédure stockée PSS_DateEmbaucheVisiteur affichant la liste des visiteurs en selectionnant une date d'embauche*/
@VIS_DATEEMBAUCHE DATE
/*paramétre @VIS_DATEEMBAUCHE de type DATE*/
AS
/*Sélection du numéro, du nom et du prénom du visiteurs ou la date selectionner correpond a la date d'embauche du visiteurs*/
SELECT VIS_MATRICULE, VIS_NOM, VIS_PRENOM 
FROM VISITEUR
WHERE VIS_DATEEMBAUCHE = @VIS_DATEEMBAUCHE


GO


CREATE PROC PSS_NombreVisiteur
/*Création de la procédure stockée PSS_NombreVisiteur affichant le nombre de visiteurs*/
AS
/*Sélection du nombre de visiteurs */
SELECT COUNT(*) AS [Nombre de visiteurs]
FROM VISITEUR

GO

CREATE PROC PSS_NombreVisiteurParDate
/*Création de la procédure stockée PSS_NombreVisiteur affichant le nombre de visiteurs 
Avec une date d'embauche en paramètre */
@UneDateEmbauche DATE
AS
/*Sélection du nombre de visiteurs*/
SELECT COUNT(*) AS [Nombre de visiteurs]
FROM VISITEUR
WHERE @UneDateEmbauche = VIS_DATEEMBAUCHE


/*Création des procédures stockées pour la fonctionnalité consultation des praticiens*/


GO

CREATE PROC PSS_ListeMedic AS
/*Retourne la liste des médicament offert aux praticiens*/
SELECT SUM(O.OFF_QTE) AS 'Echantillons offerts' ,M.MED_DEPOTLEGAL, MED_NOMCOMMERCIAL, MED_COMPOSITION, MED_EFFETS, MED_CONTREINDIC
FROM MEDICAMENT M INNER JOIN OFFRIR O ON M.MED_DEPOTLEGAL = O.MED_DEPOTLEGAL
WHERE M.MED_DEPOTLEGAL IN(SELECT DISTINCT MED_DEPOTLEGAL FROM OFFRIR)
group by M.MED_DEPOTLEGAL, MED_NOMCOMMERCIAL, MED_COMPOSITION, MED_EFFETS, MED_CONTREINDIC
GO

CREATE PROC PSS_NombreMedic AS
/*Retourne le nombre de médicament offert aux praticiens*/
SELECT COUNT(*) AS 'Nombre de médicaments'
FROM MEDICAMENT
WHERE MED_DEPOTLEGAL IN(SELECT MED_DEPOTLEGAL FROM OFFRIR)

go

CREATE PROC PSS_ListePraMedic @idmedic VARCHAR(50) AS
/*Retourne la liste des praticien qui ce sont vu offrir le medicament envoyé*/
SELECT P.PRA_NUM, PRA_NOM, PRA_PRENOM, SUM(OFF_QTE) AS 'Quantitée vendu'
FROM OFFRIR O 
INNER JOIN RAPPORT_VISITE RV ON O.RAP_NUM = RV.RAP_NUM
INNER JOIN PRATICIEN P ON RV.PRA_NUM = P.PRA_NUM
WHERE MED_DEPOTLEGAL = @idmedic
GROUP BY P.PRA_NUM, PRA_NOM, PRA_PRENOM

/*Création des procédures stockées pour la fonctionnalité consultation des praticiens*/

GO

CREATE PROC PSS_ListePraticien AS
/*Retourne la liste des praticiens*/
SELECT PRA_NUM, PRA_NOM, PRA_PRENOM, TYP_LIBELLE
FROM PRATICIEN P INNER JOIN TYPE_PRATICIEN TP ON P.TYP_CODE = TP.TYP_CODE
ORDER BY PRA_NOM, PRA_PRENOM ASC

GO

CREATE PROC PSS_DetailPraticien @id INT AS
/*Retourne les informations d'un praticiens selectionné*/
SELECT PRA_NOM, PRA_PRENOM, PRA_ADRESSE, PRA_VILLE, PRA_CP, TYP_LIBELLE, TYP_LIEU
FROM PRATICIEN P INNER JOIN TYPE_PRATICIEN TP ON P.TYP_CODE = TP.TYP_CODE
WHERE PRA_NUM = @id

GO

CREATE PROC PSS_NombrePraticien AS
/*Retourne le nombre de praticien*/
SELECT COUNT(*) as 'Nombre de praticien' FROM PRATICIEN