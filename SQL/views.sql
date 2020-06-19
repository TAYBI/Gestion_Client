CREATE VIEW statistique_par_type
AS
 SELECT Type_cong�, COUNT(*) as Nombre, MIN(Dur�e) as Minimum,  MAX(Dur�e) as Maximum , 
		AVG(Dur�e) as Moyenne, SUM(Dur�e) as Total
 FROM Conge
 GROUP BY Type_cong�


CREATE VIEW durree_total_annee_mois
AS
 SELECT DATEPART(yy, Date_cong�) as Annee, DATEPART(mm, Date_cong�) as Mois, SUM(Dur�e) as Total
 FROM Conge
 GROUP BY DATEPART(yy, Date_cong�) , DATEPART(mm, Date_cong�)