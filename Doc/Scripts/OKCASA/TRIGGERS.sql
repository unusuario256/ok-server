CREATE SEQUENCE SEQ_SERVICIO;
CREATE SEQUENCE SEQ_EQUIPO;
CREATE SEQUENCE SEQ_SOLICITUD;
CREATE SEQUENCE SEQ_INSPECCION;

CREATE OR REPLACE TRIGGER TRG_ID_SERVICIO
BEFORE INSERT ON SERVICIO
FOR EACH ROW
BEGIN
    :NEW.ID_SERVICIO:=SEQ_SERVICIO.NEXTVAL;
END;

CREATE OR REPLACE TRIGGER TRG_ID_EQUIPO
BEFORE INSERT ON EQUIPO
FOR EACH ROW
BEGIN
    :NEW.ID_EQUIPO:=SEQ_EQUIPO.NEXTVAL;
END;

CREATE OR REPLACE TRIGGER TRG_ID_SOLICITUD
BEFORE INSERT ON SOLICITUD
FOR EACH ROW
BEGIN
    :NEW.ID_SOLICITUD:=SEQ_SOLICITUD.NEXTVAL;
END;

CREATE OR REPLACE TRIGGER TRG_ID_INSPECCION
BEFORE INSERT ON INSPECCION
FOR EACH ROW
BEGIN
    :NEW.ID_INSPECCION:=SEQ_INSPECCION.NEXTVAL;
END;