// Skipping function Equals(none), it contains poisonous unsupported syntaxes

func @_DDD.Core.Common.DomainObjects.Entity.GetHashCode$$() -> i32 loc("D:\\Projetos\\DDD.Core\\src\\building-blocks\\DDD.Core.Common\\DomainObjects\\Entity.cs" :18 :8) {
^entry :
br ^0

^0: // JumpBlock
// Entity from another assembly: GetType
%0 = cbde.unknown : none loc("D:\\Projetos\\DDD.Core\\src\\building-blocks\\DDD.Core.Common\\DomainObjects\\Entity.cs" :20 :20) // GetType() (InvocationExpression)
%1 = cbde.unknown : i32 loc("D:\\Projetos\\DDD.Core\\src\\building-blocks\\DDD.Core.Common\\DomainObjects\\Entity.cs" :20 :20) // GetType().GetHashCode() (InvocationExpression)
%2 = constant 907 : i32 loc("D:\\Projetos\\DDD.Core\\src\\building-blocks\\DDD.Core.Common\\DomainObjects\\Entity.cs" :20 :46)
%3 = muli %1, %2 : i32 loc("D:\\Projetos\\DDD.Core\\src\\building-blocks\\DDD.Core.Common\\DomainObjects\\Entity.cs" :20 :20)
%4 = cbde.unknown : none loc("D:\\Projetos\\DDD.Core\\src\\building-blocks\\DDD.Core.Common\\DomainObjects\\Entity.cs" :20 :53) // Not a variable of known type: Id
%5 = cbde.unknown : i32 loc("D:\\Projetos\\DDD.Core\\src\\building-blocks\\DDD.Core.Common\\DomainObjects\\Entity.cs" :20 :53) // Id.GetHashCode() (InvocationExpression)
%6 = addi %3, %5 : i32 loc("D:\\Projetos\\DDD.Core\\src\\building-blocks\\DDD.Core.Common\\DomainObjects\\Entity.cs" :20 :19)
return %6 : i32 loc("D:\\Projetos\\DDD.Core\\src\\building-blocks\\DDD.Core.Common\\DomainObjects\\Entity.cs" :20 :12)

^1: // ExitBlock
cbde.unreachable

}
func @_DDD.Core.Common.DomainObjects.Entity.ToString$$() -> none loc("D:\\Projetos\\DDD.Core\\src\\building-blocks\\DDD.Core.Common\\DomainObjects\\Entity.cs" :23 :8) {
^entry :
br ^0

^0: // JumpBlock
// Entity from another assembly: GetType
%0 = cbde.unknown : none loc("D:\\Projetos\\DDD.Core\\src\\building-blocks\\DDD.Core.Common\\DomainObjects\\Entity.cs" :25 :22) // GetType() (InvocationExpression)
%1 = cbde.unknown : none loc("D:\\Projetos\\DDD.Core\\src\\building-blocks\\DDD.Core.Common\\DomainObjects\\Entity.cs" :25 :22) // GetType().Name (SimpleMemberAccessExpression)
%2 = cbde.unknown : none loc("D:\\Projetos\\DDD.Core\\src\\building-blocks\\DDD.Core.Common\\DomainObjects\\Entity.cs" :25 :43) // Not a variable of known type: Id
%3 = cbde.unknown : none loc("D:\\Projetos\\DDD.Core\\src\\building-blocks\\DDD.Core.Common\\DomainObjects\\Entity.cs" :25 :19) // $"{GetType().Name} [Id={Id}]" (InterpolatedStringExpression)
return %3 : none loc("D:\\Projetos\\DDD.Core\\src\\building-blocks\\DDD.Core.Common\\DomainObjects\\Entity.cs" :25 :12)

^1: // ExitBlock
cbde.unreachable

}
