--
-- PostgreSQL database dump
--

-- Dumped from database version 16.1
-- Dumped by pg_dump version 16.1

-- Started on 2024-08-04 21:53:33

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

--
-- TOC entry 4883 (class 1262 OID 98563)
-- Name: tabor; Type: DATABASE; Schema: -; Owner: postgres
--

CREATE DATABASE tabor WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'Russian_Kazakhstan.1251';


ALTER DATABASE tabor OWNER TO postgres;

\connect tabor

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

--
-- TOC entry 4 (class 2615 OID 2200)
-- Name: public; Type: SCHEMA; Schema: -; Owner: pg_database_owner
--

CREATE SCHEMA public;


ALTER SCHEMA public OWNER TO pg_database_owner;

--
-- TOC entry 4884 (class 0 OID 0)
-- Dependencies: 4
-- Name: SCHEMA public; Type: COMMENT; Schema: -; Owner: pg_database_owner
--

COMMENT ON SCHEMA public IS 'standard public schema';


SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- TOC entry 219 (class 1259 OID 98934)
-- Name: bookings; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.bookings (
    c_id integer,
    r_id integer,
    bookin date,
    bookout date,
    b_id integer NOT NULL,
    payment integer,
    cheque_id integer
);


ALTER TABLE public.bookings OWNER TO postgres;

--
-- TOC entry 221 (class 1259 OID 98956)
-- Name: breakfast; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.breakfast (
    dish character varying,
    price numeric
);


ALTER TABLE public.breakfast OWNER TO postgres;

--
-- TOC entry 215 (class 1259 OID 98896)
-- Name: clients; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.clients (
    c_id integer NOT NULL,
    fullname character varying,
    sex character varying,
    passport character varying,
    email character varying,
    phone character varying,
    cpassword character varying
);


ALTER TABLE public.clients OWNER TO postgres;

--
-- TOC entry 216 (class 1259 OID 98903)
-- Name: employees; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.employees (
    e_id integer NOT NULL,
    fullname character varying,
    dateofbirth date,
    login character varying,
    epassword character varying,
    post character varying,
    phone character varying,
    homeaddress character varying,
    salary numeric
);


ALTER TABLE public.employees OWNER TO postgres;

--
-- TOC entry 218 (class 1259 OID 98917)
-- Name: orders; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.orders (
    o_id integer NOT NULL,
    title character varying,
    price numeric,
    e_id integer,
    c_id integer,
    s_id integer,
    status character varying
);


ALTER TABLE public.orders OWNER TO postgres;

--
-- TOC entry 217 (class 1259 OID 98910)
-- Name: rooms; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.rooms (
    r_id integer NOT NULL,
    status integer,
    type character varying,
    price numeric
);


ALTER TABLE public.rooms OWNER TO postgres;

--
-- TOC entry 220 (class 1259 OID 98949)
-- Name: services_catalogue; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.services_catalogue (
    title character varying,
    price numeric,
    s_id integer NOT NULL,
    quantity integer
);


ALTER TABLE public.services_catalogue OWNER TO postgres;

--
-- TOC entry 4875 (class 0 OID 98934)
-- Dependencies: 219
-- Data for Name: bookings; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.bookings VALUES (3, 102, '2024-05-02', '2024-05-10', 1, 21600, 1);
INSERT INTO public.bookings VALUES (6, 105, '2024-05-14', '2024-05-18', 5, 5400, 2);
INSERT INTO public.bookings VALUES (5, 106, '2024-05-18', '2024-05-22', 13, 26000, 10);
INSERT INTO public.bookings VALUES (4, 106, '2024-05-18', '2024-05-22', 15, 26000, 10);
INSERT INTO public.bookings VALUES (2, 104, '2024-07-15', '2024-07-17', 101, 6000, 103);
INSERT INTO public.bookings VALUES (1, 104, '2024-07-15', '2024-07-17', 100, 6000, 103);
INSERT INTO public.bookings VALUES (6, 104, '2024-07-15', '2024-07-17', 104, 6500, 106);
INSERT INTO public.bookings VALUES (7, 104, '2024-07-15', '2024-07-17', 105, 6500, 106);


--
-- TOC entry 4877 (class 0 OID 98956)
-- Dependencies: 221
-- Data for Name: breakfast; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.breakfast VALUES ('coffee', 100);
INSERT INTO public.breakfast VALUES ('pancakes', 180);
INSERT INTO public.breakfast VALUES ('omelet', 160);
INSERT INTO public.breakfast VALUES ('fruit salad', 120);
INSERT INTO public.breakfast VALUES ('green tea', 40);
INSERT INTO public.breakfast VALUES ('orange juice', 80);


--
-- TOC entry 4871 (class 0 OID 98896)
-- Dependencies: 215
-- Data for Name: clients; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.clients VALUES (1, 'Natalya Petrova', 'f', 'N123456', 'npetrova@mail.ru', '87293356767', '123456');
INSERT INTO public.clients VALUES (2, 'Fedor Solovei', 'm', 'N451237', 'solovei@mail.ru', '87283306760', 'qwerty');
INSERT INTO public.clients VALUES (3, 'Aleksandr Reshentev', 'm', 'N145230', 'areshetnev@mail.ru', '87283306561', 'asdfgh');
INSERT INTO public.clients VALUES (4, 'Anna Korshunova', 'f', 'N221667', 'akorshun@mail.ru', '87313608899', '123456');
INSERT INTO public.clients VALUES (5, 'Sergei Sidorov', 'm', 'N331288', 'sidorovsergei@mail.ru', '89293306711', 'qwerty');
INSERT INTO public.clients VALUES (6, 'Elena Lebedeva', 'f', 'N120356', 'lebedeva@mail.ru', '87280312069', 'asdfgh');
INSERT INTO public.clients VALUES (7, 'Fedor Solovei', 'm', 'N050298', 'solovei@mail.ru', '87283394731', '123456');


--
-- TOC entry 4872 (class 0 OID 98903)
-- Dependencies: 216
-- Data for Name: employees; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.employees VALUES (2, 'Dmitrii Naumov', '2002-08-03', 'naumov', 'qwerty', 'administrator', '89792169110', 'ул. Маркса, д. 13', 70000);
INSERT INTO public.employees VALUES (3, ' Aleksandra Rudakova', '2002-10-24', 'rudakova', '1', 'service', '87122169234', 'ул. Ленина, д. 48', 50000);
INSERT INTO public.employees VALUES (1, 'Alena Makarova', '1998-12-17', 'makarova', '1', 'administrator', '89292164059', 'ул. Пушкина, д. 5', 70000);
INSERT INTO public.employees VALUES (4, 'Marya Zakharova', '1996-03-04', 'zakharova', '2', 'service', '89342170198', 'ул. Гоголя, д. 8', 50000);


--
-- TOC entry 4874 (class 0 OID 98917)
-- Dependencies: 218
-- Data for Name: orders; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.orders VALUES (100, 'test', 0, 3, 3, 1, 'in progress');
INSERT INTO public.orders VALUES (3, 'coffee, omelet', 250, 4, 1, 1, 'completed');
INSERT INTO public.orders VALUES (5, 'towels/bathrobe change', 0, 4, 4, 3, 'in progress');
INSERT INTO public.orders VALUES (1, 'towels/bathrobe change', 0, 3, 3, 1, 'in progress');
INSERT INTO public.orders VALUES (2, 'full room cleaning', 0, 4, 3, 3, 'completed');
INSERT INTO public.orders VALUES (8, 'towels/bathrobe change', 0, 3, 6, 1, 'completed');
INSERT INTO public.orders VALUES (7, 'full room cleaning', 0, 4, 2, 3, 'in progress');
INSERT INTO public.orders VALUES (6, 'bed-clothes changing', 0, 3, 2, 4, 'completed');
INSERT INTO public.orders VALUES (35, 'towels/bathrobe change', 0, 3, 3, 1, 'in progress');
INSERT INTO public.orders VALUES (4, 'full room cleaning', 0, 3, 1, 2, 'completed');
INSERT INTO public.orders VALUES (87, 'dry cleaning', 0, 3, 3, 1, 'in progress');


--
-- TOC entry 4873 (class 0 OID 98910)
-- Dependencies: 217
-- Data for Name: rooms; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.rooms VALUES (101, 0, 'twin', 6500);
INSERT INTO public.rooms VALUES (102, 1, 'sngl', 2700);
INSERT INTO public.rooms VALUES (103, 0, 'sngl', 2700);
INSERT INTO public.rooms VALUES (105, 0, 'sngl', 2700);
INSERT INTO public.rooms VALUES (107, 0, 'singl', 2700);
INSERT INTO public.rooms VALUES (106, 1, 'twin', 6500);
INSERT INTO public.rooms VALUES (200, 0, 'DBL', 7500);
INSERT INTO public.rooms VALUES (104, 1, 'dbl', 6000);


--
-- TOC entry 4876 (class 0 OID 98949)
-- Dependencies: 220
-- Data for Name: services_catalogue; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.services_catalogue VALUES ('towels/bathrobe change', 0, 1, 3);
INSERT INTO public.services_catalogue VALUES ('dry cleaning', 1500, 2, 2);
INSERT INTO public.services_catalogue VALUES ('full room cleaning', 0, 3, 10);
INSERT INTO public.services_catalogue VALUES ('bed-clothes changing', 0, 4, 7);


--
-- TOC entry 4721 (class 2606 OID 98938)
-- Name: bookings bookings_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.bookings
    ADD CONSTRAINT bookings_pkey PRIMARY KEY (b_id);


--
-- TOC entry 4713 (class 2606 OID 98902)
-- Name: clients clients_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.clients
    ADD CONSTRAINT clients_pkey PRIMARY KEY (c_id);


--
-- TOC entry 4715 (class 2606 OID 98909)
-- Name: employees employees_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.employees
    ADD CONSTRAINT employees_pkey PRIMARY KEY (e_id);


--
-- TOC entry 4719 (class 2606 OID 98923)
-- Name: orders orders_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.orders
    ADD CONSTRAINT orders_pkey PRIMARY KEY (o_id);


--
-- TOC entry 4717 (class 2606 OID 98916)
-- Name: rooms rooms_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.rooms
    ADD CONSTRAINT rooms_pkey PRIMARY KEY (r_id);


--
-- TOC entry 4723 (class 2606 OID 98955)
-- Name: services_catalogue services_catalogue_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.services_catalogue
    ADD CONSTRAINT services_catalogue_pkey PRIMARY KEY (s_id);


--
-- TOC entry 4726 (class 2606 OID 98939)
-- Name: bookings bookings_c_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.bookings
    ADD CONSTRAINT bookings_c_id_fkey FOREIGN KEY (c_id) REFERENCES public.clients(c_id);


--
-- TOC entry 4727 (class 2606 OID 98944)
-- Name: bookings bookings_r_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.bookings
    ADD CONSTRAINT bookings_r_id_fkey FOREIGN KEY (r_id) REFERENCES public.rooms(r_id);


--
-- TOC entry 4724 (class 2606 OID 106720)
-- Name: orders orders_c_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.orders
    ADD CONSTRAINT orders_c_id_fkey FOREIGN KEY (c_id) REFERENCES public.clients(c_id) NOT VALID;


--
-- TOC entry 4725 (class 2606 OID 98924)
-- Name: orders orders_e_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.orders
    ADD CONSTRAINT orders_e_id_fkey FOREIGN KEY (e_id) REFERENCES public.employees(e_id);


-- Completed on 2024-08-04 21:53:34

--
-- PostgreSQL database dump complete
--

