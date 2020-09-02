‘
`D:\Projetos\DDD.Core\src\building-blocks\DDD.Core.Common\Configuration\FluentValidationConfig.cs
	namespace 	
DDD
 
. 
Core 
. 
Common 
. 
Configuration '
{ 
public 

static 
class "
FluentValidationConfig .
{ 
public 
static 
void 
AddFluentValidation .
(. /
this/ 3
IServiceCollection4 F
servicesG O
)O P
{		 	
services

 
.

 
	AddScoped

 
<

 
ValidationResult

 /
>

/ 0
(

0 1
)

1 2
;

2 3
} 	
} 
} Ï
YD:\Projetos\DDD.Core\src\building-blocks\DDD.Core.Common\DomainObjects\DomainException.cs
	namespace 	
DDD
 
. 
Core 
. 
Common 
. 
DomainObjects '
{ 
[ 
Serializable 
] 
public 

class 
DomainException  
:! "
	Exception# ,
{ 
public		 
DomainException		 
(		 
)		  
{		! "
}		# $
	protected 
DomainException !
(! "
SerializationInfo" 3
info4 8
,8 9
StreamingContext: J
contextK R
)R S
:T U
baseU Y
(Y Z
infoZ ^
,^ _
context` g
)g h
{i j
}k l
public 
DomainException 
( 
string %
message& -
)- .
:/ 0
base1 5
(5 6
message6 =
)= >
{? @
}A B
public 
DomainException 
( 
string %
message& -
,- .
	Exception/ 8
innerException9 G
)G H
:I J
baseK O
(O P
messageP W
,W X
innerExceptionY g
)g h
{i j
}k l
} 
} Ç
PD:\Projetos\DDD.Core\src\building-blocks\DDD.Core.Common\DomainObjects\Entity.cs
	namespace 	
DDD
 
. 
Core 
. 
Common 
. 
DomainObjects '
{ 
public 

abstract 
class 
Entity  
{ 
public 
Guid 
Id 
{ 
get 
; 
	protected '
set( +
;+ ,
}- .
public		 
override		 
bool		 
Equals		 #
(		# $
object		$ *
obj		+ .
)		. /
{

 	
var 
	compareTo 
= 
obj 
as  "
Entity# )
;) *
if 
( 
ReferenceEquals 
(  
this  $
,$ %
	compareTo& /
)/ 0
)0 1
return2 8
true9 =
;= >
if 
( 
	compareTo 
is 
null !
)! "
return# )
false* /
;/ 0
return 
Id 
. 
Equals 
( 
	compareTo &
.& '
Id' )
)) *
;* +
} 	
public 
override 
int 
GetHashCode '
(' (
)( )
{ 	
return 
( 
GetType 
( 
) 
. 
GetHashCode )
() *
)* +
*, -
$num. 1
)1 2
+3 4
Id5 7
.7 8
GetHashCode8 C
(C D
)D E
;E F
} 	
public 
override 
string 
ToString '
(' (
)( )
{ 	
return 
$" 
{ 
GetType 
( 
) 
.  
Name  $
}$ %
 [Id=% *
{* +
Id+ -
}- .
]. /
"/ 0
;0 1
} 	
} 
} í
XD:\Projetos\DDD.Core\src\building-blocks\DDD.Core.Common\DomainObjects\IAggregateRoot.cs
	namespace 	
DDD
 
. 
Core 
. 
Common 
. 
DomainObjects '
{ 
public 

	interface 
IAggregateRoot #
{$ %
}& '
} Å
UD:\Projetos\DDD.Core\src\building-blocks\DDD.Core.Common\DomainObjects\ValueObject.cs
	namespace 	
DDD
 
. 
Core 
. 
Common 
. 
DomainObjects '
{ 
public 

abstract 
class 
ValueObject %
{ 
	protected		 
abstract		 
IEnumerable		 &
<		& '
object		' -
>		- .!
GetEqualityComponents		/ D
(		D E
)		E F
;		F G
public 
override 
bool 
Equals #
(# $
object$ *
obj+ .
). /
{ 	
if 
( 
obj 
== 
null 
) 
return 
false 
; 
if 
( 
GetType 
( 
) 
!= 
obj  
.  !
GetType! (
(( )
)) *
)* +
return 
false 
; 
var 
valueObject 
= 
( 
ValueObject *
)* +
obj+ .
;. /
return !
GetEqualityComponents (
(( )
)) *
.* +
SequenceEqual+ 8
(8 9
valueObject9 D
.D E!
GetEqualityComponentsE Z
(Z [
)[ \
)\ ]
;] ^
} 	
public 
override 
int 
GetHashCode '
(' (
)( )
{ 	
return !
GetEqualityComponents (
(( )
)) *
. 
	Aggregate 
( 
$num 
, 
( 
current &
,& '
obj( +
)+ ,
=>- /
{ 
	unchecked 
{ 
return 
current &
*' (
$num) +
+, -
(. /
obj/ 2
?2 3
.3 4
GetHashCode4 ?
(? @
)@ A
??B D
$numE F
)F G
;G H
}   
}!! 
)!! 
;!! 
}"" 	
}## 
}$$ Û
SD:\Projetos\DDD.Core\src\building-blocks\DDD.Core.Common\Handlers\CommandHandler.cs
	namespace 	
DDD
 
. 
Core 
. 
Common 
. 
Handlers "
{ 
public 

abstract 
class 
CommandHandler (
:) *
Handler+ 2
{ 
	protected 
CommandHandler  
(  !
ValidationResult! 1
validationResult2 B
)B C
:		 
base		 
(		 
validationResult		 #
)		# $
{		% &
}		' (
	protected 
bool 
Validate 
<  
T  !
,! "
U" #
># $
($ %
T% &
command' .
). /
where0 5
T6 7
:8 9
Command: A
<A B
UB C
>C D
{ 	
var 
result 
= 
command  
.  !
IsValid! (
(( )
)) *
;* +
foreach 
( 
var 
error 
in !
command" )
.) *
ValidationResult* :
.: ;
Errors; A
)A B
{ 
_validationResult !
.! "
Errors" (
.( )
Add) ,
(, -
error- 2
)2 3
;3 4
} 
return 
result 
; 
} 	
} 
} ›
QD:\Projetos\DDD.Core\src\building-blocks\DDD.Core.Common\Handlers\EventHandler.cs
	namespace 	
DDD
 
. 
Core 
. 
Common 
. 
Handlers "
{ 
public 

abstract 
class 
EventHandler &
:' (
Handler) 0
{ 
	protected 
EventHandler 
( 
ValidationResult /
validationResult0 @
)@ A
: 
base 
( 
validationResult #
)# $
{% &
}' (
}		 
}

 Ó
LD:\Projetos\DDD.Core\src\building-blocks\DDD.Core.Common\Handlers\Handler.cs
	namespace 	
DDD
 
. 
Core 
. 
Common 
. 
Handlers "
{ 
public 

abstract 
class 
Handler !
{ 
	protected 
Handler 
( 
ValidationResult *
validationResult+ ;
); <
{ 	
_validationResult		 
=		 
validationResult		  0
;		0 1
}

 	
	protected 
readonly 
ValidationResult +
_validationResult, =
;= >
	protected 
void 
AddError 
(  
string  &
errorMessage' 3
)3 4
{ 	
_validationResult 
. 
Errors $
.$ %
Add% (
(( )
new) ,
ValidationFailure- >
(> ?
string? E
.E F
EmptyF K
,K L
errorMessageM Y
)Y Z
)Z [
;[ \
} 	
	protected 
void 
ClearErrors "
(" #
)# $
{ 	
_validationResult 
. 
Errors $
.$ %
Clear% *
(* +
)+ ,
;, -
} 	
} 
} ›
QD:\Projetos\DDD.Core\src\building-blocks\DDD.Core.Common\Handlers\QueryHandler.cs
	namespace 	
DDD
 
. 
Core 
. 
Common 
. 
Handlers "
{ 
public 

abstract 
class 
QueryHandler &
:' (
Handler) 0
{ 
	protected 
QueryHandler 
( 
ValidationResult /
validationResult0 @
)@ A
: 
base 
( 
validationResult #
)# $
{% &
}' (
}		 
}

 ø
LD:\Projetos\DDD.Core\src\building-blocks\DDD.Core.Common\Messages\Command.cs
	namespace 	
DDD
 
. 
Core 
. 
Common 
. 
Messages "
{ 
public 

abstract 
class 
Command !
<! "
T" #
># $
:% &
Message' .
,. /
IRequest0 8
<8 9
T9 :
>: ;
{ 
	protected		 
Command		 
(		 
)		 
:

 
base

 
(

 
)

 
{

 
}

 
public 
ValidationResult 
ValidationResult  0
{1 2
get3 6
;6 7
	protected8 A
setB E
;E F
}G H
public 
virtual 
bool 
IsValid #
(# $
)$ %
{ 	
throw 
new #
NotImplementedException -
(- .
). /
;/ 0
} 	
} 
} ½
JD:\Projetos\DDD.Core\src\building-blocks\DDD.Core.Common\Messages\Event.cs
	namespace 	
DDD
 
. 
Core 
. 
Common 
. 
Messages "
{ 
public 

class 
Event 
: 
Message  
,  !
INotification" /
{ 
public 
Event 
( 
) 
: 
base 
( 
) 
{ 
} 
}		 
}

 ã	
LD:\Projetos\DDD.Core\src\building-blocks\DDD.Core.Common\Messages\Message.cs
	namespace 	
DDD
 
. 
Core 
. 
Common 
. 
Messages "
{ 
public 

abstract 
class 
Message !
{ 
	protected 
Message 
( 
) 
{ 	
	TimeStamp		 
=		 
DateTime		  
.		  !
Now		! $
;		$ %
MessageType

 
=

 
GetType

 !
(

! "
)

" #
.

# $
Name

$ (
;

( )
} 	
public 
string 
MessageType !
{" #
get$ '
;' (
private) 0
set1 4
;4 5
}6 7
public 
Guid 
AggregateId 
{  !
get" %
;% &
	protected' 0
set1 4
;4 5
}6 7
public 
DateTime 
	TimeStamp !
{" #
get$ '
;' (
	protected) 2
set3 6
;6 7
}8 9
} 
} «
JD:\Projetos\DDD.Core\src\building-blocks\DDD.Core.Common\Messages\Query.cs
	namespace 	
DDD
 
. 
Core 
. 
Common 
. 
Messages "
{ 
public 

abstract 
class 
Query 
<  
T  !
>! "
:# $
Message% ,
,, -
IRequest. 6
<6 7
T7 8
>8 9
{ 
	protected 
Query 
( 
) 
: 
base 
( 
) 
{ 
} 
}		 
}

 