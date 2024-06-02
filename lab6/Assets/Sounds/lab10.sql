--1. ���������� ������ ����
begin
    null;
end;

--2. ���� ���� � ����� �����
begin        
  dbms_output.put_line('����� �����');    
end;

--3-4. ����������� � �������� �����
select keyword from v$reserved_words where length = 1 and keyword != 'A';
select keyword from v$reserved_words where length > 1 and keyword != 'A' order by keyword;

--5. ���������� ������ ����
declare 
numVar number(3) := 11;
numVar2 number(3) := 2;
numRes number(10,2);
decVar number(10,2) := 222.22;
decVar2 number(10,2) := round(222.22);
eVar number := 2.22E-2;
dateVar date := sysdate;
charVar varchar2(50) := '���';
clobVar clob := '����� ���';
booleanVar boolean := true;
begin
numRes := numVar / numVar2;
dbms_output.put_line('/ numRes = ' ||numRes);
numRes := numVar * numVar2;
dbms_output.put_line('* numRes = ' ||numRes);
numRes := numVar + numVar2;
dbms_output.put_line('+ numRes = ' ||numRes);
numRes := numVar - numVar2;
dbms_output.put_line('- numRes = ' ||numRes);
numRes := numVar mod numVar2;
dbms_output.put_line('mod numRes = ' ||numRes);
end;

--6. �������� � ����������� 
declare 
strConst constant varchar(20) := 'qeqehi';
charConst constant char(10) := 'priv';
numConst constant number(10,2) := 12.12;
begin 
dbms_output.put_line('concat = ' ||strConst||' '||charConst);
dbms_output.put_line('concatV2 = ' || concat(strConst,charConst));
dbms_output.put_line('length = ' || length(strConst));
dbms_output.put_line('rtrim = ' || rtrim(strConst, 'hi'));
dbms_output.put_line('numConst + 2 = ' || to_char(numConst + 2));
end;

--7-8. ����� %type, %rowtype
declare 
subject sys.subject.subject%type;
faculty_rec sys.faculty%rowtype;
begin
subject := '���';
faculty_rec.faculty := '����';
dbms_output.put_line('subject = ' || subject);
dbms_output.put_line('faculty_res = ' || faculty_rec.faculty);
end;

--9. if
declare x pls_integer := 17;
begin
if 8>x then dbms_output.put_line('8>'||x);
elsif 8=x then dbms_output.put_line('8='||x);
elsif 12>x then dbms_output.put_line('12>'||x);
elsif 12=x then dbms_output.put_line('12='||x);
else dbms_output.put_line('12<'||x);
end if;
end;

--10. case
declare 
    x pls_integer :=17;
begin
case
    when 8> x then dbms_output.put_line(' 8 > '||x);
    when 8= x then dbms_output.put_line(' 8 = '||x);
    when 12 = x then dbms_output.put_line(' 12 = '||x);
    when x between 13 and 20 then dbms_output.put_line('13 <=' || x ||'<= 20' );
    else dbms_output.put_line('else');
end case;
end;

--11-13. loop-while-for
declare 
    x pls_integer := 0;
begin
    loop 
    x:= x+1;
    dbms_output.put_line(x);
    exit when x >5;
    end loop;
for k in 1..5
loop
    dbms_output.put_line(k);
    end loop;
while (x>0)
loop 
    x:= x-1;
    dbms_output.put_line(x);
    end loop;
end;
