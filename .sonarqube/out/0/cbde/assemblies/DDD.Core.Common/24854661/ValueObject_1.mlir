func @_DDD.Core.Common.DomainObjects.ValueObject.Equals$object$(none) -> i1 loc("D:\\Projetos\\DDD.Core\\src\\building-blocks\\DDD.Core.Common\\DomainObjects\\ValueObject.cs" :10 :8) {
^entry (%_obj : none):
%0 = cbde.alloca none loc("D:\\Projetos\\DDD.Core\\src\\building-blocks\\DDD.Core.Common\\DomainObjects\\ValueObject.cs" :10 :36)
cbde.store %_obj, %0 : memref<none> loc("D:\\Projetos\\DDD.Core\\src\\building-blocks\\DDD.Core.Common\\DomainObjects\\ValueObject.cs" :10 :36)
br ^0

^0: // BinaryBranchBlock
%1 = cbde.unknown : none loc("D:\\Projetos\\DDD.Core\\src\\building-blocks\\DDD.Core.Common\\DomainObjects\\ValueObject.cs" :12 :16) // Not a variable of known type: obj
%2 = cbde.unknown : none loc("D:\\Projetos\\DDD.Core\\src\\building-blocks\\DDD.Core.Common\\DomainObjects\\ValueObject.cs" :12 :23) // null (NullLiteralExpression)
%3 = cbde.unknown : i1  loc("D:\\Projetos\\DDD.Core\\src\\building-blocks\\DDD.Core.Common\\DomainObjects\\ValueObject.cs" :12 :16) // comparison of unknown type: obj == null
cond_br %3, ^1, ^2 loc("D:\\Projetos\\DDD.Core\\src\\building-blocks\\DDD.Core.Common\\DomainObjects\\ValueObject.cs" :12 :16)

^1: // JumpBlock
%4 = constant 0 : i1 loc("D:\\Projetos\\DDD.Core\\src\\building-blocks\\DDD.Core.Common\\DomainObjects\\ValueObject.cs" :13 :23) // false
return %4 : i1 loc("D:\\Projetos\\DDD.Core\\src\\building-blocks\\DDD.Core.Common\\DomainObjects\\ValueObject.cs" :13 :16)

^2: // BinaryBranchBlock
// Entity from another assembly: GetType
%5 = cbde.unknown : none loc("D:\\Projetos\\DDD.Core\\src\\building-blocks\\DDD.Core.Common\\DomainObjects\\ValueObject.cs" :15 :16) // GetType() (InvocationExpression)
%6 = cbde.unknown : none loc("D:\\Projetos\\DDD.Core\\src\\building-blocks\\DDD.Core.Common\\DomainObjects\\ValueObject.cs" :15 :29) // Not a variable of known type: obj
%7 = cbde.unknown : none loc("D:\\Projetos\\DDD.Core\\src\\building-blocks\\DDD.Core.Common\\DomainObjects\\ValueObject.cs" :15 :29) // obj.GetType() (InvocationExpression)
%8 = cbde.unknown : i1  loc("D:\\Projetos\\DDD.Core\\src\\building-blocks\\DDD.Core.Common\\DomainObjects\\ValueObject.cs" :15 :16) // comparison of unknown type: GetType() != obj.GetType()
cond_br %8, ^3, ^4 loc("D:\\Projetos\\DDD.Core\\src\\building-blocks\\DDD.Core.Common\\DomainObjects\\ValueObject.cs" :15 :16)

^3: // JumpBlock
%9 = constant 0 : i1 loc("D:\\Projetos\\DDD.Core\\src\\building-blocks\\DDD.Core.Common\\DomainObjects\\ValueObject.cs" :16 :23) // false
return %9 : i1 loc("D:\\Projetos\\DDD.Core\\src\\building-blocks\\DDD.Core.Common\\DomainObjects\\ValueObject.cs" :16 :16)

^4: // JumpBlock
%10 = cbde.unknown : none loc("D:\\Projetos\\DDD.Core\\src\\building-blocks\\DDD.Core.Common\\DomainObjects\\ValueObject.cs" :18 :43) // Not a variable of known type: obj
%11 = cbde.unknown : none loc("D:\\Projetos\\DDD.Core\\src\\building-blocks\\DDD.Core.Common\\DomainObjects\\ValueObject.cs" :18 :30) // (ValueObject)obj (CastExpression)
// Skipped because MethodDeclarationSyntax or ClassDeclarationSyntax or NamespaceDeclarationSyntax: GetEqualityComponents
%13 = cbde.unknown : none loc("D:\\Projetos\\DDD.Core\\src\\building-blocks\\DDD.Core.Common\\DomainObjects\\ValueObject.cs" :20 :19) // GetEqualityComponents() (InvocationExpression)
%14 = cbde.unknown : none loc("D:\\Projetos\\DDD.Core\\src\\building-blocks\\DDD.Core.Common\\DomainObjects\\ValueObject.cs" :20 :57) // Not a variable of known type: valueObject
%15 = cbde.unknown : none loc("D:\\Projetos\\DDD.Core\\src\\building-blocks\\DDD.Core.Common\\DomainObjects\\ValueObject.cs" :20 :57) // valueObject.GetEqualityComponents() (InvocationExpression)
%16 = cbde.unknown : i1 loc("D:\\Projetos\\DDD.Core\\src\\building-blocks\\DDD.Core.Common\\DomainObjects\\ValueObject.cs" :20 :19) // GetEqualityComponents().SequenceEqual(valueObject.GetEqualityComponents()) (InvocationExpression)
return %16 : i1 loc("D:\\Projetos\\DDD.Core\\src\\building-blocks\\DDD.Core.Common\\DomainObjects\\ValueObject.cs" :20 :12)

^5: // ExitBlock
cbde.unreachable

}
// Skipping function GetHashCode(), it contains poisonous unsupported syntaxes

