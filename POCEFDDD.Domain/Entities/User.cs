using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace POCEFDDD.Model.Entities
{
    public class User
    {
        private string _name;
        private string _email;

        protected User() { }

        public User(string name, string email)
        {
            this.Id = Guid.NewGuid();
            this.Name = name;
            this.Email = email;

        }

        public Guid Id { get; protected set; }

        public string Name
        {
            get { return _name; }

            set
            {
                Assert.IsNotEmpty(value, string.Format("Campo {0} é obrigatório.", "name"));
                //Assert.Expresion<int>(ValidateOperations.Greater, value.Length, 3, "Deve ser maior que 3 carcteres.");
                _name = value;
            }
        }

        public string Email
        {
            get { return _email; }

            set
            {
                Assert.Expresion<int>(ValidateOperations.Greater, value.Length, 3, "Deve ser maior que 3 carcteres.");
                _email = value;
            }
        }
    }

    public enum ValidateOperations
    {
        Equal,
        NotEqual,
        Greater,
        GreaterOrEquals,
        Lesser,
        LesserOrEquals
    }

    public static class Assert
    {

        public static void IsNotEmpty(string value, string message)
        {
            if (string.IsNullOrEmpty(value))
                throw new Exception(message);
        }

        public static void Expresion<T>(ValidateOperations operation, object value1, object value2, string message)
        {
            Expression<Func<bool>> expression = null;

            ConstantExpression left = Expression.Constant(Convert.ChangeType(value1, Type.GetTypeCode(typeof(T))));
            ConstantExpression right = Expression.Constant(Convert.ChangeType(value2, Type.GetTypeCode(typeof(T))));

            switch (operation)
            {

                case ValidateOperations.Equal:
                    expression = Expression.Lambda<Func<bool>>(Expression.Equal(left, right));
                    break;
                case ValidateOperations.NotEqual:
                    expression = Expression.Lambda<Func<bool>>(Expression.NotEqual(left, right));
                    break;
                case ValidateOperations.Greater:
                    expression = Expression.Lambda<Func<bool>>(Expression.GreaterThan(left, right));
                    break;
                case ValidateOperations.GreaterOrEquals:
                    expression = Expression.Lambda<Func<bool>>(Expression.GreaterThanOrEqual(left, right));
                    break;
                case ValidateOperations.Lesser:
                    expression = Expression.Lambda<Func<bool>>(Expression.LessThan(left, right));
                    break;
                case ValidateOperations.LesserOrEquals:
                    expression = Expression.Lambda<Func<bool>>(Expression.LessThanOrEqual(left, right));
                    break;
            }


            if (!expression.Compile().Invoke())
                throw new Exception(message);

        }

    }
}
