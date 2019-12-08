----TRIGGER FUNCTIONS-----

-- FUNCTION: public."Aadharnumberdigits"()

-- DROP FUNCTION public."Aadharnumberdigits"();

CREATE FUNCTION public."Aadharnumberdigits"()
    RETURNS trigger
    LANGUAGE 'plpgsql'
    COST 100
    VOLATILE NOT LEAKPROOF
AS $BODY$BEGIN
    RAISE EXCEPTION 'aadhar number must be 16 digits';
    RETURN NEW;
END;
$BODY$;

ALTER FUNCTION public."Aadharnumberdigits"()
    OWNER TO postgres;

COMMENT ON FUNCTION public."Aadharnumberdigits"()
    IS 'The aadhar number must be of 16 digits. If the user enters other number of digits, then it will throw an error.';


-- FUNCTION: public.passwordtriggerfunction()

-- DROP FUNCTION public.passwordtriggerfunction();

CREATE FUNCTION public.passwordtriggerfunction()
    RETURNS trigger
    LANGUAGE 'plpgsql'
    COST 100
    VOLATILE NOT LEAKPROOF
AS $BODY$
BEGIN
    RAISE EXCEPTION 'password cannot be less than 5 characters';
    RETURN NEW;
END;
$BODY$;

ALTER FUNCTION public.passwordtriggerfunction()
    OWNER TO postgres;

COMMENT ON FUNCTION public.passwordtriggerfunction()
    IS 'If the password entered is less than 5 characters, then this trigger will be activated.';


-- FUNCTION: public.phonenumberdigits()

-- DROP FUNCTION public.phonenumberdigits();

CREATE FUNCTION public.phonenumberdigits()
    RETURNS trigger
    LANGUAGE 'plpgsql'
    COST 100
    VOLATILE NOT LEAKPROOF
AS $BODY$BEGIN
    RAISE EXCEPTION 'Phone number must be 10 digits';
    RETURN NEW;
END;
$BODY$;

ALTER FUNCTION public.phonenumberdigits()
    OWNER TO postgres;

COMMENT ON FUNCTION public.phonenumberdigits()
    IS 'If the entered phone number is not of 10 digits, then this trigger will be activated.';

