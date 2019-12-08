-- FUNCTION: public.campaign_delete(integer)

-- DROP FUNCTION public.campaign_delete(integer);

CREATE OR REPLACE FUNCTION public.campaign_delete(
	_campaign_id integer)
    RETURNS integer
    LANGUAGE 'plpgsql'

    COST 100
    VOLATILE 
    
AS $BODY$
	begin
		delete from campaign where campaign_id=_campaign_id;

		if found then
			return 1;
		else
			return 0;
		end if;
	end
$BODY$;

ALTER FUNCTION public.campaign_delete(integer)
    OWNER TO postgres;

-- FUNCTION: public.campaign_insert(integer, text, text, date)

-- DROP FUNCTION public.campaign_insert(integer, text, text, date);

CREATE OR REPLACE FUNCTION public.campaign_insert(
	_campaign_id integer,
	_cname text,
	_clocation text,
	_cdate date)
    RETURNS integer
    LANGUAGE 'plpgsql'

    COST 100
    VOLATILE 
    
AS $BODY$
	begin
		insert into campaign (
			campaign_id,
			cname,
			clocation,
			cdate
			)
		values(
			_campaign_id,
			_cname,
			_clocation, 
			_cdate
			);

		if found then
			return 1;
		else
			return 0;
		end if;
	end
	$BODY$;

ALTER FUNCTION public.campaign_insert(integer, text, text, date)
    OWNER TO postgres;


-- FUNCTION: public.campaign_select()

-- DROP FUNCTION public.campaign_select();

CREATE OR REPLACE FUNCTION public.campaign_select(
	)
    RETURNS TABLE(_campaign_id integer, _cname text, _clocation text, _cdate date) 
    LANGUAGE 'plpgsql'

    COST 100
    VOLATILE 
    ROWS 1000
    
AS $BODY$
begin
	return query
	select campaign_id,cname,clocation,cdate from campaign order by campaign_id;
end
$BODY$;

ALTER FUNCTION public.campaign_select()
    OWNER TO postgres;


-- FUNCTION: public.campaign_update(integer, text, text)

-- DROP FUNCTION public.campaign_update(integer, text, text);

CREATE OR REPLACE FUNCTION public.campaign_update(
	_campaign_id integer,
	_cname text,
	_clocation text)
    RETURNS integer
    LANGUAGE 'plpgsql'

    COST 100
    VOLATILE 
    
AS $BODY$
	begin
		update campaign
		set	

			campaign_id=_campaign_id,
			cname=_cname,
			clocation=_clocation
		where campaign_id=_campaign_id;

		if found then
			return 1;
		else
			return 0;
		end if;
	end
	$BODY$;

ALTER FUNCTION public.campaign_update(integer, text, text)
    OWNER TO postgres;

-- FUNCTION: public.disaster_delete(integer)

-- DROP FUNCTION public.disaster_delete(integer);

CREATE OR REPLACE FUNCTION public.disaster_delete(
	_disaster_id integer)
    RETURNS integer
    LANGUAGE 'plpgsql'

    COST 100
    VOLATILE 
    
AS $BODY$
	begin
		delete from disaster where disaster_id=_disaster_id;

		if found then
			return 1;
		else
			return 0;
		end if;
	end
$BODY$;

ALTER FUNCTION public.disaster_delete(integer)
    OWNER TO postgres;

-- FUNCTION: public.disaster_insert(integer, text, text, bigint, date, text)

-- DROP FUNCTION public.disaster_insert(integer, text, text, bigint, date, text);

CREATE OR REPLACE FUNCTION public.disaster_insert(
	_disaster_id integer,
	_dname text,
	_dlocation text,
	_total_loss bigint,
	_disasterdate date,
	_area_affected text)
    RETURNS integer
    LANGUAGE 'plpgsql'

    COST 100
    VOLATILE 
    
AS $BODY$
	begin
		insert into disaster(
			disaster_id,
			dname,
			dlocation,
			total_loss,
            disasterdate,
			area_affected
			)
		values(
			_disaster_id,
			_dname,
			_dlocation,
			_total_loss,
            _disasterdate,
			_area_affected
			);

		if found then
			return 1;
		else
			return 0;
		end if;
	end
	$BODY$;

ALTER FUNCTION public.disaster_insert(integer, text, text, bigint, date, text)
    OWNER TO postgres;

-- FUNCTION: public.disaster_select()

-- DROP FUNCTION public.disaster_select();

CREATE OR REPLACE FUNCTION public.disaster_select(
	)
    RETURNS TABLE(_disaster_id integer, _dname text, _dlocation text, _total_loss bigint, _disasterdate date, _area_affected text) 
    LANGUAGE 'plpgsql'

    COST 100
    VOLATILE 
    ROWS 1000
    
AS $BODY$
begin
	return query
	select disaster_id,dname,dlocation,total_loss,disasterdate,area_affected from disaster order by disaster_id;
end
$BODY$;

ALTER FUNCTION public.disaster_select()
    OWNER TO postgres;

-- FUNCTION: public.disaster_update(integer, text, text, bigint, text)

-- DROP FUNCTION public.disaster_update(integer, text, text, bigint, text);

CREATE OR REPLACE FUNCTION public.disaster_update(
	_disaster_id integer,
	_dname text,
	_dlocation text,
	_total_loss bigint,
	_area_affected text)
    RETURNS integer
    LANGUAGE 'plpgsql'

    COST 100
    VOLATILE 
    
AS $BODY$
	begin
		update disaster
		set	

			disaster_id=_disaster_id,
			dname=_dname,
			dlocation=_dlocation,
			total_loss=_total_loss,
			area_affected=_area_affected
		where disaster_id=_disaster_id;

		if found then
			return 1;
		else
			return 0;
		end if;
	end
	$BODY$;

ALTER FUNCTION public.disaster_update(integer, text, text, bigint, text)
    OWNER TO postgres;

-- FUNCTION: public.donation_delete(integer)

-- DROP FUNCTION public.donation_delete(integer);

CREATE OR REPLACE FUNCTION public.donation_delete(
	_donation_id integer)
    RETURNS integer
    LANGUAGE 'plpgsql'

    COST 100
    VOLATILE 
    
AS $BODY$
	begin
		delete from donation where donation_id=_donation_id;

		if found then
			return 1;
		else
			return 0;
		end if;
	end
$BODY$;

ALTER FUNCTION public.donation_delete(integer)
    OWNER TO postgres;

-- FUNCTION: public.donation_insert(integer, text, bigint, bigint, integer)

-- DROP FUNCTION public.donation_insert(integer, text, bigint, bigint, integer);

CREATE OR REPLACE FUNCTION public.donation_insert(
	_donation_id integer,
	_donar_name text,
	_phno bigint,
	_amount_donated bigint,
	_disaster_id integer)
    RETURNS integer
    LANGUAGE 'plpgsql'

    COST 100
    VOLATILE 
    
AS $BODY$
	begin
		insert into donation(
			donation_id,
			donar_name,
			phno,
			amount_donated,
            disaster_id
			
			)
		values(
			_donation_id,
			_donar_name,
			_phno,
			_amount_donated,
            _disaster_id
			);

		if found then
			return 1;
		else
			return 0;
		end if;
	end
	$BODY$;

ALTER FUNCTION public.donation_insert(integer, text, bigint, bigint, integer)
    OWNER TO postgres;

-- FUNCTION: public.donation_select()

-- DROP FUNCTION public.donation_select();

CREATE OR REPLACE FUNCTION public.donation_select(
	)
    RETURNS TABLE(_donation_id integer, _donar_name text, _phno bigint, _amount_donated bigint, _disaster_id integer) 
    LANGUAGE 'plpgsql'

    COST 100
    VOLATILE 
    ROWS 1000
    
AS $BODY$
begin
	return query
	select donation_id,donar_name,phno,amount_donated,disaster_id from donation order by donation_id;
end
$BODY$;

ALTER FUNCTION public.donation_select()
    OWNER TO postgres;

-- FUNCTION: public.donation_update(integer, text, bigint, bigint, integer)

-- DROP FUNCTION public.donation_update(integer, text, bigint, bigint, integer);

CREATE OR REPLACE FUNCTION public.donation_update(
	_donation_id integer,
	_donar_name text,
	_phno bigint,
	_amount_donated bigint,
	_disaster_id integer)
    RETURNS integer
    LANGUAGE 'plpgsql'

    COST 100
    VOLATILE 
    
AS $BODY$begin
	update donation
	set 
		donar_name=_donar_name,
		phno=_phno,
		amount_donated=_amount_donated,
		disaster_id=_disaster_id

	where donation_id=_donation_id;

	if found then
		return 1;
	else
		return 0;
	end if;
end
$BODY$;

ALTER FUNCTION public.donation_update(integer, text, bigint, bigint, integer)
    OWNER TO postgres;

-- FUNCTION: public.officer_delete(integer)

-- DROP FUNCTION public.officer_delete(integer);

CREATE OR REPLACE FUNCTION public.officer_delete(
	_officer_id integer)
    RETURNS integer
    LANGUAGE 'plpgsql'

    COST 100
    VOLATILE 
    
AS $BODY$
	begin
		delete from officer where officer_id=_officer_id;

		if found then
			return 1;
		else
			return 0;
		end if;
	end
$BODY$;

ALTER FUNCTION public.officer_delete(integer)
    OWNER TO postgres;

-- FUNCTION: public.officer_insert(integer, integer, text, text, integer, integer)

-- DROP FUNCTION public.officer_insert(integer, integer, text, text, integer, integer);

CREATE OR REPLACE FUNCTION public.officer_insert(
	_officer_id integer,
	_disasters_id integer,
	_dname text,
	_oname text,
	_campaign_id integer,
	_user_id integer)
    RETURNS integer
    LANGUAGE 'plpgsql'

    COST 100
    VOLATILE 
    
AS $BODY$
	begin
		insert into officer(
			officer_id,
			disasters_id,
			dname,
			oname,
			campaign_id,
			
		
			user_id
			)
		values(
			_officer_id,
			_disasters_id,
			_dname,
			_oname,
			_campaign_id,
			
			_user_id
			
			);

		if found then
			return 1;
		else
			return 0;
		end if;
	end
	$BODY$;

ALTER FUNCTION public.officer_insert(integer, integer, text, text, integer, integer)
    OWNER TO postgres;

-- FUNCTION: public.officer_select()

-- DROP FUNCTION public.officer_select();

CREATE OR REPLACE FUNCTION public.officer_select(
	)
    RETURNS TABLE(_officer_id integer, _disasters_id integer, _dname text, _oname text, _campaign_id integer, _user_id integer) 
    LANGUAGE 'plpgsql'

    COST 100
    VOLATILE 
    ROWS 1000
    
AS $BODY$
begin
	return query
	select officer_id,disasters_id,dname,oname,campaign_id,user_id from officer order by officer_id;
end
$BODY$;

ALTER FUNCTION public.officer_select()
    OWNER TO postgres;

-- FUNCTION: public.officer_update(integer, integer, text, text, integer, integer)

-- DROP FUNCTION public.officer_update(integer, integer, text, text, integer, integer);

CREATE OR REPLACE FUNCTION public.officer_update(
	_officer_id integer,
	_disasters_id integer,
	_dname text,
	_oname text,
	_campaign_id integer,
	_user_id integer)
    RETURNS integer
    LANGUAGE 'plpgsql'

    COST 100
    VOLATILE 
    
AS $BODY$
begin
	update officer
		set	

			disasters_id=_disasters_id,
			dname=_dname,
			oname=_oname,
			campaign_id=_campaign_id,
			user_id=_user_id

		where officer_id=_officer_id;

		if found then
			return 1;
		else
			return 0;
		end if;
end
$BODY$;

ALTER FUNCTION public.officer_update(integer, integer, text, text, integer, integer)
    OWNER TO postgres;

-- FUNCTION: public.user_delete(integer)

-- DROP FUNCTION public.user_delete(integer);

CREATE OR REPLACE FUNCTION public.user_delete(
	_user_id integer)
    RETURNS integer
    LANGUAGE 'plpgsql'

    COST 100
    VOLATILE 
    
AS $BODY$
	begin
		delete from user_login where user_id=_user_id;

		if found then
			return 1;
		else
			return 0;
		end if;
	end
$BODY$;

ALTER FUNCTION public.user_delete(integer)
    OWNER TO postgres;

-- FUNCTION: public.user_insert(integer, text, text, bigint, bigint, integer)

-- DROP FUNCTION public.user_insert(integer, text, text, bigint, bigint, integer);

CREATE OR REPLACE FUNCTION public.user_insert(
	_user_id integer,
	_user_name text,
	_user_password text,
	_phno bigint,
	_aadhar_no bigint,
	_disasters_id integer)
    RETURNS integer
    LANGUAGE 'plpgsql'

    COST 100
    VOLATILE 
    
AS $BODY$
	begin
		insert into user_login(
			user_id,
			user_name,
			user_password,
			phno,
			aadhar_no,
			disasters_id)
		values(
			_user_id,
			_user_name,
			_user_password,
			_phno,
			_aadhar_no,
			_disasters_id);

		if found then
			return 1;
		else
			return 0;
		end if;
	end
	$BODY$;

ALTER FUNCTION public.user_insert(integer, text, text, bigint, bigint, integer)
    OWNER TO postgres;

-- FUNCTION: public.user_select()

-- DROP FUNCTION public.user_select();

CREATE OR REPLACE FUNCTION public.user_select(
	)
    RETURNS TABLE(_user_id integer, _user_name text, _user_password text, _phno bigint, _aadhar_no bigint, _disasters_id integer) 
    LANGUAGE 'plpgsql'

    COST 100
    VOLATILE 
    ROWS 1000
    
AS $BODY$
begin
	return query
	select user_id,user_name,user_password,phno,aadhar_no,disasters_id from user_login order by user_id;
end
$BODY$;

ALTER FUNCTION public.user_select()
    OWNER TO postgres;

-- FUNCTION: public.user_update(integer, text, text, bigint, bigint, integer)

-- DROP FUNCTION public.user_update(integer, text, text, bigint, bigint, integer);

CREATE OR REPLACE FUNCTION public.user_update(
	_user_id integer,
	_user_name text,
	_user_password text,
	_phno bigint,
	_aadhar_no bigint,
	_disasters_id integer)
    RETURNS integer
    LANGUAGE 'plpgsql'

    COST 100
    VOLATILE 
    
AS $BODY$
	begin
		update user_login
		set	

			user_name=_user_name,
			user_password=_user_password,
			phno=_phno,
			aadhar_no=_aadhar_no,
			disasters_id=_disasters_id

		where user_id=_user_id;

		if found then
			return 1;
		else
			return 0;
		end if;
	end
	$BODY$;

ALTER FUNCTION public.user_update(integer, text, text, bigint, bigint, integer)
    OWNER TO postgres;




----STORED PROCEDURES-----
-- PROCEDURE: public.changepassword(text, text)

-- DROP PROCEDURE public.changepassword(text, text);

CREATE OR REPLACE PROCEDURE public.changepassword(
	uname text,
	newpass text)
LANGUAGE 'sql'

AS $BODY$
UPDATE user_login set user_password=newpass where user_name=uname;
$BODY$;

-- PROCEDURE: public.update_adminphno(text, bigint)

-- DROP PROCEDURE public.update_adminphno(text, bigint);

CREATE OR REPLACE PROCEDURE public.update_adminphno(
	namearg text,
	newphno bigint)
LANGUAGE 'sql'

AS $BODY$
UPDATE admin_login SET phno = newphno WHERE name=namearg;
$BODY$;

-- PROCEDURE: public.update_userphno(text, bigint)

-- DROP PROCEDURE public.update_userphno(text, bigint);

CREATE OR REPLACE PROCEDURE public.update_userphno(
	namearg text,
	newphno bigint)
LANGUAGE 'sql'

AS $BODY$
UPDATE user_login SET phno = newphno WHERE user_name=namearg;
$BODY$;


