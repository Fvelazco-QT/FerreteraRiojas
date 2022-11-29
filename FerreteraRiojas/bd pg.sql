--
-- PostgreSQL database dump
--

-- Dumped from database version 15.1
-- Dumped by pg_dump version 15.1

-- Started on 2022-11-28 22:53:20

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

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- TOC entry 217 (class 1259 OID 16409)
-- Name: Empleado; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Empleado" (
    "idEmpleado" integer NOT NULL,
    "Usuario" text NOT NULL,
    "Contraseña" text NOT NULL,
    "Nombre" text NOT NULL,
    "Status" bit(3)
);


ALTER TABLE public."Empleado" OWNER TO postgres;

--
-- TOC entry 216 (class 1259 OID 16408)
-- Name: Empleado_idEmpleado_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public."Empleado" ALTER COLUMN "idEmpleado" ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public."Empleado_idEmpleado_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- TOC entry 215 (class 1259 OID 16401)
-- Name: Producto; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Producto" (
    "idProducto" integer NOT NULL,
    "Nombre" text,
    "Precio" integer,
    "Descripcion" text,
    "Codigo" text,
    "Unidad" text,
    "Departamento" text,
    "Status" bit(1)
);


ALTER TABLE public."Producto" OWNER TO postgres;

--
-- TOC entry 214 (class 1259 OID 16400)
-- Name: Inventa_idProducto_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public."Producto" ALTER COLUMN "idProducto" ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public."Inventa_idProducto_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- TOC entry 3327 (class 0 OID 16409)
-- Dependencies: 217
-- Data for Name: Empleado; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public."Empleado" ("idEmpleado", "Usuario", "Contraseña", "Nombre", "Status") FROM stdin;
1	Fvelazco	1234	Francisco Velazco Cortez	\N
\.


--
-- TOC entry 3325 (class 0 OID 16401)
-- Dependencies: 215
-- Data for Name: Producto; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public."Producto" ("idProducto", "Nombre", "Precio", "Descripcion", "Codigo", "Unidad", "Departamento", "Status") FROM stdin;
3	Clavo	2	Clavo 1 pulgada	1516	KG	2	\N
5	Lija	0	Grado 1000 de agua	8571	PZA	6	\N
9	Clavos	2	Clavo 1 pulgada	15163	KG	2	\N
7	Tuberia PVC	10	Tuberia tipo PVC 1/2 pulgada	91834	M	6	\N
2	Clavos	2	Clavo 1 pulgada	15163	KG	2	\N
4	Clavos	2	Clavo 1 pulgada	1516	KG	2	\N
10	Cinta	34	Cinta aislante	8595	PZA	6	\N
\.


--
-- TOC entry 3333 (class 0 OID 0)
-- Dependencies: 216
-- Name: Empleado_idEmpleado_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."Empleado_idEmpleado_seq"', 1, true);


--
-- TOC entry 3334 (class 0 OID 0)
-- Dependencies: 214
-- Name: Inventa_idProducto_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."Inventa_idProducto_seq"', 13, true);


--
-- TOC entry 3181 (class 2606 OID 16415)
-- Name: Empleado Empleado_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Empleado"
    ADD CONSTRAINT "Empleado_pkey" PRIMARY KEY ("idEmpleado");


--
-- TOC entry 3179 (class 2606 OID 16405)
-- Name: Producto Inventa_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Producto"
    ADD CONSTRAINT "Inventa_pkey" PRIMARY KEY ("idProducto");


-- Completed on 2022-11-28 22:53:21

--
-- PostgreSQL database dump complete
--

