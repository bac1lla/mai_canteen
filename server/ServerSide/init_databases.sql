drop role mai_canteen;

create role mai_canteen with
	NOSUPERUSER
	NOCREATEDB
	NOCREATEROLE
	NOINHERIT
	LOGIN
	NOREPLICATION
	NOBYPASSRLS
	CONNECTION LIMIT 100
	ENCRYPTED PASSWORD '12345';

drop database mai_canteen;

create database mai_canteen with 
	owner = mai_canteen;

\c mai_canteen

drop schema mai_canteen;

create schema mai_canteen;

grant all privileges
    on schema mai_canteen
    to mai_canteen;

grant all privileges 
	on all tables in schema mai_canteen
	to mai_canteen;

grant all privileges
	on database mai_canteen
	to mai_canteen;

\c postgres

drop role mai_canteen_archive;

create role mai_canteen_archive with
	NOSUPERUSER
	NOCREATEDB
	NOCREATEROLE
	NOINHERIT
	LOGIN
	NOREPLICATION
	NOBYPASSRLS
	CONNECTION LIMIT 100
	ENCRYPTED PASSWORD '12345';

drop database mai_canteen_archive;

create database mai_canteen_archive with 
	owner = mai_canteen_archive;

\c mai_canteen_archive

drop schema mai_canteen_archive;

create schema mai_canteen_archive;

grant all privileges
    on schema mai_canteen_archive
    to mai_canteen_archive;

grant all privileges 
	on all tables in schema mai_canteen_archive
	to mai_canteen_archive;

grant all privileges
	on database mai_canteen_archive
	to mai_canteen_archive;

\c postgres