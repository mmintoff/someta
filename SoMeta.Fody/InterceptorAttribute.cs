﻿using System;
using Mono.Cecil;

namespace Someta.Fody
{
    public struct InterceptorAttribute
    {
        public TypeDefinition DeclaringType { get; }
        public IMemberDefinition DeclaringMember { get; }
        public CustomAttribute Attribute { get; }
        public TypeReference AttributeType => Attribute.AttributeType;
        public int Index { get; }
        public InterceptorScope Scope { get; }

        public InterceptorAttribute(TypeDefinition declaringType, IMemberDefinition declaringMember, CustomAttribute attribute, int index, InterceptorScope scope) : this()
        {
            if (index < 0)
                throw new ArgumentException(nameof(index));

            DeclaringType = declaringType;
            DeclaringMember = declaringMember;
            Attribute = attribute;
            Index = index;
            Scope = scope;
        }

        public override string ToString()
        {
            return AttributeType.FullName;
        }
    }
}