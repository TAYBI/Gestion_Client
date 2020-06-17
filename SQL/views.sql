CREATE VIEW statistique_par_type
AS
 SELECT Type_cong�, COUNT(*) as Nombre, MIN(Dur�e) as Minimum,  MAX(Dur�e) as Maximum , 
		AVG(Dur�e) as Moyenne, SUM(Dur�e) as Total
 FROM Conge
 GROUP BY Type_cong�



SELECT * FROM statistique_par_type