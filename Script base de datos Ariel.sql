
CREATE SCHEMA `` ;
create table libro (
 id_libro int,
 genero_libro varchar(15),
 cant_pags int,
 editorial varchar(15),
 autor varchar(15),
 PRIMARY KEY (id_libro)
);

select* from libro;
select
genero_libro,
cant_pags
from libro where cant_pags in (200,500) and genero_libro = 'terror' or genero_libro='suspenso';

select 
genero_libro, 
editorial,
autor
from libro where genero_libro= 'suspenso' or genero_libro='terror'
group by editorial = 'PANINI'
having autor='Junji Ito';

select count(id_libro) from libro where genero_libro='ciencia ficcion';
select sum(cant_pags) from libro where autor='Edgar Alan Poe';

 
