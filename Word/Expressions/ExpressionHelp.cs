using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Word
{
    public static class ExpressionHelp
    {
        public static T GetPropertyValue<T>(this Expression<Func<T>> lamda)
        {
            return lamda.Compile().Invoke();
        }

        public static void SetPropertyValue<T>(this Expression<Func<T>> lamda, T value)
        {
            var expression = (lamda as LambdaExpression).Body as MemberExpression;
            var propertyInfo = (PropertyInfo)expression.Member;
            var target = Expression.Lambda(expression.Expression).Compile().DynamicInvoke();

            propertyInfo.SetValue(target, value);
        }
    }
}
