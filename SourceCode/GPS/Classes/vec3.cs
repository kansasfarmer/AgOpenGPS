﻿//Please, if you use this, share the improvements

using System;

namespace AgOpenGPS
{
    /// <summary>
    /// Represents a three dimensional vector.
    /// </summary>
    public struct vec3
    {
        public double x;
        public double h;
        public double z;


        public vec3(double x, double y, double z)
        {
            this.x = x;
            this.h = y;
            this.z = z;
        }


       public vec3(vec3 v)
        {
            this.x = v.x;
            this.h = v.h;
            this.z = v.z;
        }

        public double HeadingXZ()
        {
            return Math.Atan2(x, z);
        }
 
        public void Normalize()
        {
            double length = GetLength();
            if (length == 0)
            {
                throw new DivideByZeroException("Trying to normalize a vector with length of zero.");
            }

            x /= length;
            h /= length;
            z /= length;
        }

        //Returns the length of the vector
        public double GetLength()
        {
            return System.Math.Sqrt(x * x + h * h + z * z);
        }

        // Calculates the squared length of the vector.
        public double GetLengthSquared()
        {
            return (x * x + h * h + z * z);
        }

        public static vec3 operator -(vec3 lhs, vec3 rhs)
        {
            return new vec3(lhs.x - rhs.x, lhs.h - rhs.h, lhs.z - rhs.z);
        }

        //public static bool operator ==(vec3 lhs, vec3 rhs)
        //{
        //    return (lhs.x == rhs.x && lhs.z == rhs.z && lhs.h == rhs.h);
        //}

        //public static bool operator !=(vec3 lhs, vec3 rhs)
        //{
        //    return (lhs.x != rhs.x && lhs.z != rhs.z && lhs.h != rhs.h);
        //}



    }

    //

    /// <summary>
    /// x,y,z,k
    /// </summary>
    public struct vec4
    {
        public double x; //easting
        public double y; //heading etc
        public double z; //northing
        public double k;    //altitude


        public vec4(double x, double y, double z, double k)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.k = k;
        }
    }



    public struct vec2
    {
        public double x; //easting
        public double z; //northing


        public vec2(double x, double z)
        {
            this.x = x;
            this.z = z;
       }

        public static vec2 operator -(vec2 lhs, vec2 rhs)
        {
            return new vec2(lhs.x - rhs.x, lhs.z - rhs.z);
        }


        //public static bool operator ==(vec2 lhs, vec2 rhs)
        //{
        //    return (lhs.x == rhs.x && lhs.z == rhs.z);
        //}

        //public static bool operator !=(vec2 lhs, vec2 rhs)
        //{
        //    return (lhs.x != rhs.x && lhs.z != rhs.z);
        //}

        //calculate the heading of dirction pointx to pointz
        public double HeadingXZ()
        {
            return Math.Atan2(x, z);
        }

        //normalize to 1
        public void Normalize()
        {
            double length = GetLength();
            if (length == 0)
            {
                throw new DivideByZeroException("Trying to normalize a vector with length of zero.");
            }

            x /= length;
            z /= length;
        }

        //Returns the length of the vector
        public double GetLength()
        {
            return System.Math.Sqrt(x * x + z * z);
        }

        // Calculates the squared length of the vector.
        public double GetLengthSquared()
        {
            return (x * x + z * z);
        }  
        
    }

    //strucutre for contour guidance
    public struct cvec
    {
        public double x;
        public double z;
        public double h;
        public int strip;
        public int pt;

        //specialized contour vector
         public cvec(double x, double z, double h, int s, int p)
        {
            this.x = x;
            this.z = z;
            this.h = h;
            this.strip = s;
            this.pt = p;
        }

         public cvec(vec3 v)
         {
             this.x = v.x;
             this.z = v.z;
             this.h = v.h;
             this.strip = 99999;
             this.pt = 99999;
         }


    }
}



//public double this[int index]
//{
//    get
//    {
//        if (index == 0) return x;
//        else if (index == 1) return z;
//        else throw new Exception("Out of range.");
//    }
//    set
//    {
//        if (index == 0) x = value;
//        else if (index == 1) z = value;
//        else throw new Exception("Out of range.");
//    }
//}

//public vec2(double s)
//{
//    x = z = s;
//}

//public vec2(vec2 v)
//{
//    this.x = v.x;
//    this.z = v.z;
//}

//public vec2(vec3 v)
//{
//    this.x = v.x;
//    this.z = v.z;
//}

//public static vec2 operator +(vec2 lhs, vec2 rhs)
//{
//    return new vec2(lhs.x + rhs.x, lhs.z + rhs.z);
//}

//public static vec2 operator +(vec2 lhs, double rhs)
//{
//    return new vec2(lhs.x + rhs, lhs.z + rhs);
//}


//public static vec2 operator -(vec2 lhs, double rhs)
//{
//    return new vec2(lhs.x - rhs, lhs.z - rhs);
//}

//public static vec2 operator *(vec2 self, double s)
//{
//    return new vec2(self.x * s, self.z * s);
//}

//public static vec2 operator *(double lhs, vec2 rhs)
//{
//    return new vec2(rhs.x * lhs, rhs.z * lhs);
//}

//public static vec2 operator *(vec2 lhs, vec2 rhs)
//{
//    return new vec2(rhs.x * lhs.x, rhs.z * lhs.z);
//}

//public static vec2 operator /(vec2 lhs, double rhs)
//{
//    return new vec2(lhs.x / rhs, lhs.z / rhs);
//}

//public double[] to_array()
//{
//    return new[] { x, z };
//}
