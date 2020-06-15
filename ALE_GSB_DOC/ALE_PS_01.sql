

/*Cr�ation des proc�dures stock�es pour la fonctionnalit� consultation des comptes rendus*/

USE BBLLGSB
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
ORDER BY VIS_NOM ASC


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