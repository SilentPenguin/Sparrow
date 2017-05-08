namespace Sparrow.Numerics
{
    public partial struct Vector<T> where T : struct
    {
        public T x { get { return this[0]; } }
        public T y { get { return this[1]; } }
        public T z { get { return this[2]; } }
        public T w { get { return this[3]; } }
        public Vector<T> xx { get { return new Vector<T>(x, x); } }
        public Vector<T> xy { get { return new Vector<T>(x, y); } }
        public Vector<T> xz { get { return new Vector<T>(x, z); } }
        public Vector<T> xw { get { return new Vector<T>(x, w); } }
        public Vector<T> yx { get { return new Vector<T>(y, x); } }
        public Vector<T> yy { get { return new Vector<T>(y, y); } }
        public Vector<T> yz { get { return new Vector<T>(y, z); } }
        public Vector<T> yw { get { return new Vector<T>(y, w); } }
        public Vector<T> zx { get { return new Vector<T>(z, x); } }
        public Vector<T> zy { get { return new Vector<T>(z, y); } }
        public Vector<T> zz { get { return new Vector<T>(z, z); } }
        public Vector<T> zw { get { return new Vector<T>(z, w); } }
        public Vector<T> wx { get { return new Vector<T>(w, x); } }
        public Vector<T> wy { get { return new Vector<T>(w, y); } }
        public Vector<T> wz { get { return new Vector<T>(w, z); } }
        public Vector<T> ww { get { return new Vector<T>(w, w); } }
        public Vector<T> xxx { get { return new Vector<T>(x, x, x); } }
        public Vector<T> xxy { get { return new Vector<T>(x, x, y); } }
        public Vector<T> xxz { get { return new Vector<T>(x, x, z); } }
        public Vector<T> xxw { get { return new Vector<T>(x, x, w); } }
        public Vector<T> xyx { get { return new Vector<T>(x, y, x); } }
        public Vector<T> xyy { get { return new Vector<T>(x, y, y); } }
        public Vector<T> xyz { get { return new Vector<T>(x, y, z); } }
        public Vector<T> xyw { get { return new Vector<T>(x, y, w); } }
        public Vector<T> xzx { get { return new Vector<T>(x, z, x); } }
        public Vector<T> xzy { get { return new Vector<T>(x, z, y); } }
        public Vector<T> xzz { get { return new Vector<T>(x, z, z); } }
        public Vector<T> xzw { get { return new Vector<T>(x, z, w); } }
        public Vector<T> xwx { get { return new Vector<T>(x, w, x); } }
        public Vector<T> xwy { get { return new Vector<T>(x, w, y); } }
        public Vector<T> xwz { get { return new Vector<T>(x, w, z); } }
        public Vector<T> xww { get { return new Vector<T>(x, w, w); } }
        public Vector<T> yxx { get { return new Vector<T>(y, x, x); } }
        public Vector<T> yxy { get { return new Vector<T>(y, x, y); } }
        public Vector<T> yxz { get { return new Vector<T>(y, x, z); } }
        public Vector<T> yxw { get { return new Vector<T>(y, x, w); } }
        public Vector<T> yyx { get { return new Vector<T>(y, y, x); } }
        public Vector<T> yyy { get { return new Vector<T>(y, y, y); } }
        public Vector<T> yyz { get { return new Vector<T>(y, y, z); } }
        public Vector<T> yyw { get { return new Vector<T>(y, y, w); } }
        public Vector<T> yzx { get { return new Vector<T>(y, z, x); } }
        public Vector<T> yzy { get { return new Vector<T>(y, z, y); } }
        public Vector<T> yzz { get { return new Vector<T>(y, z, z); } }
        public Vector<T> yzw { get { return new Vector<T>(y, z, w); } }
        public Vector<T> ywx { get { return new Vector<T>(y, w, x); } }
        public Vector<T> ywy { get { return new Vector<T>(y, w, y); } }
        public Vector<T> ywz { get { return new Vector<T>(y, w, z); } }
        public Vector<T> yww { get { return new Vector<T>(y, w, w); } }
        public Vector<T> zxx { get { return new Vector<T>(z, x, x); } }
        public Vector<T> zxy { get { return new Vector<T>(z, x, y); } }
        public Vector<T> zxz { get { return new Vector<T>(z, x, z); } }
        public Vector<T> zxw { get { return new Vector<T>(z, x, w); } }
        public Vector<T> zyx { get { return new Vector<T>(z, y, x); } }
        public Vector<T> zyy { get { return new Vector<T>(z, y, y); } }
        public Vector<T> zyz { get { return new Vector<T>(z, y, z); } }
        public Vector<T> zyw { get { return new Vector<T>(z, y, w); } }
        public Vector<T> zzx { get { return new Vector<T>(z, z, x); } }
        public Vector<T> zzy { get { return new Vector<T>(z, z, y); } }
        public Vector<T> zzz { get { return new Vector<T>(z, z, z); } }
        public Vector<T> zzw { get { return new Vector<T>(z, z, w); } }
        public Vector<T> zwx { get { return new Vector<T>(z, w, x); } }
        public Vector<T> zwy { get { return new Vector<T>(z, w, y); } }
        public Vector<T> zwz { get { return new Vector<T>(z, w, z); } }
        public Vector<T> zww { get { return new Vector<T>(z, w, w); } }
        public Vector<T> wxx { get { return new Vector<T>(w, x, x); } }
        public Vector<T> wxy { get { return new Vector<T>(w, x, y); } }
        public Vector<T> wxz { get { return new Vector<T>(w, x, z); } }
        public Vector<T> wxw { get { return new Vector<T>(w, x, w); } }
        public Vector<T> wyx { get { return new Vector<T>(w, y, x); } }
        public Vector<T> wyy { get { return new Vector<T>(w, y, y); } }
        public Vector<T> wyz { get { return new Vector<T>(w, y, z); } }
        public Vector<T> wyw { get { return new Vector<T>(w, y, w); } }
        public Vector<T> wzx { get { return new Vector<T>(w, z, x); } }
        public Vector<T> wzy { get { return new Vector<T>(w, z, y); } }
        public Vector<T> wzz { get { return new Vector<T>(w, z, z); } }
        public Vector<T> wzw { get { return new Vector<T>(w, z, w); } }
        public Vector<T> wwx { get { return new Vector<T>(w, w, x); } }
        public Vector<T> wwy { get { return new Vector<T>(w, w, y); } }
        public Vector<T> wwz { get { return new Vector<T>(w, w, z); } }
        public Vector<T> www { get { return new Vector<T>(w, w, w); } }
        public Vector<T> xxxx { get { return new Vector<T>(x, x, x, x); } }
        public Vector<T> xxxy { get { return new Vector<T>(x, x, x, y); } }
        public Vector<T> xxxz { get { return new Vector<T>(x, x, x, z); } }
        public Vector<T> xxxw { get { return new Vector<T>(x, x, x, w); } }
        public Vector<T> xxyx { get { return new Vector<T>(x, x, y, x); } }
        public Vector<T> xxyy { get { return new Vector<T>(x, x, y, y); } }
        public Vector<T> xxyz { get { return new Vector<T>(x, x, y, z); } }
        public Vector<T> xxyw { get { return new Vector<T>(x, x, y, w); } }
        public Vector<T> xxzx { get { return new Vector<T>(x, x, z, x); } }
        public Vector<T> xxzy { get { return new Vector<T>(x, x, z, y); } }
        public Vector<T> xxzz { get { return new Vector<T>(x, x, z, z); } }
        public Vector<T> xxzw { get { return new Vector<T>(x, x, z, w); } }
        public Vector<T> xxwx { get { return new Vector<T>(x, x, w, x); } }
        public Vector<T> xxwy { get { return new Vector<T>(x, x, w, y); } }
        public Vector<T> xxwz { get { return new Vector<T>(x, x, w, z); } }
        public Vector<T> xxww { get { return new Vector<T>(x, x, w, w); } }
        public Vector<T> xyxx { get { return new Vector<T>(x, y, x, x); } }
        public Vector<T> xyxy { get { return new Vector<T>(x, y, x, y); } }
        public Vector<T> xyxz { get { return new Vector<T>(x, y, x, z); } }
        public Vector<T> xyxw { get { return new Vector<T>(x, y, x, w); } }
        public Vector<T> xyyx { get { return new Vector<T>(x, y, y, x); } }
        public Vector<T> xyyy { get { return new Vector<T>(x, y, y, y); } }
        public Vector<T> xyyz { get { return new Vector<T>(x, y, y, z); } }
        public Vector<T> xyyw { get { return new Vector<T>(x, y, y, w); } }
        public Vector<T> xyzx { get { return new Vector<T>(x, y, z, x); } }
        public Vector<T> xyzy { get { return new Vector<T>(x, y, z, y); } }
        public Vector<T> xyzz { get { return new Vector<T>(x, y, z, z); } }
        public Vector<T> xyzw { get { return new Vector<T>(x, y, z, w); } }
        public Vector<T> xywx { get { return new Vector<T>(x, y, w, x); } }
        public Vector<T> xywy { get { return new Vector<T>(x, y, w, y); } }
        public Vector<T> xywz { get { return new Vector<T>(x, y, w, z); } }
        public Vector<T> xyww { get { return new Vector<T>(x, y, w, w); } }
        public Vector<T> xzxx { get { return new Vector<T>(x, z, x, x); } }
        public Vector<T> xzxy { get { return new Vector<T>(x, z, x, y); } }
        public Vector<T> xzxz { get { return new Vector<T>(x, z, x, z); } }
        public Vector<T> xzxw { get { return new Vector<T>(x, z, x, w); } }
        public Vector<T> xzyx { get { return new Vector<T>(x, z, y, x); } }
        public Vector<T> xzyy { get { return new Vector<T>(x, z, y, y); } }
        public Vector<T> xzyz { get { return new Vector<T>(x, z, y, z); } }
        public Vector<T> xzyw { get { return new Vector<T>(x, z, y, w); } }
        public Vector<T> xzzx { get { return new Vector<T>(x, z, z, x); } }
        public Vector<T> xzzy { get { return new Vector<T>(x, z, z, y); } }
        public Vector<T> xzzz { get { return new Vector<T>(x, z, z, z); } }
        public Vector<T> xzzw { get { return new Vector<T>(x, z, z, w); } }
        public Vector<T> xzwx { get { return new Vector<T>(x, z, w, x); } }
        public Vector<T> xzwy { get { return new Vector<T>(x, z, w, y); } }
        public Vector<T> xzwz { get { return new Vector<T>(x, z, w, z); } }
        public Vector<T> xzww { get { return new Vector<T>(x, z, w, w); } }
        public Vector<T> xwxx { get { return new Vector<T>(x, w, x, x); } }
        public Vector<T> xwxy { get { return new Vector<T>(x, w, x, y); } }
        public Vector<T> xwxz { get { return new Vector<T>(x, w, x, z); } }
        public Vector<T> xwxw { get { return new Vector<T>(x, w, x, w); } }
        public Vector<T> xwyx { get { return new Vector<T>(x, w, y, x); } }
        public Vector<T> xwyy { get { return new Vector<T>(x, w, y, y); } }
        public Vector<T> xwyz { get { return new Vector<T>(x, w, y, z); } }
        public Vector<T> xwyw { get { return new Vector<T>(x, w, y, w); } }
        public Vector<T> xwzx { get { return new Vector<T>(x, w, z, x); } }
        public Vector<T> xwzy { get { return new Vector<T>(x, w, z, y); } }
        public Vector<T> xwzz { get { return new Vector<T>(x, w, z, z); } }
        public Vector<T> xwzw { get { return new Vector<T>(x, w, z, w); } }
        public Vector<T> xwwx { get { return new Vector<T>(x, w, w, x); } }
        public Vector<T> xwwy { get { return new Vector<T>(x, w, w, y); } }
        public Vector<T> xwwz { get { return new Vector<T>(x, w, w, z); } }
        public Vector<T> xwww { get { return new Vector<T>(x, w, w, w); } }
        public Vector<T> yxxx { get { return new Vector<T>(y, x, x, x); } }
        public Vector<T> yxxy { get { return new Vector<T>(y, x, x, y); } }
        public Vector<T> yxxz { get { return new Vector<T>(y, x, x, z); } }
        public Vector<T> yxxw { get { return new Vector<T>(y, x, x, w); } }
        public Vector<T> yxyx { get { return new Vector<T>(y, x, y, x); } }
        public Vector<T> yxyy { get { return new Vector<T>(y, x, y, y); } }
        public Vector<T> yxyz { get { return new Vector<T>(y, x, y, z); } }
        public Vector<T> yxyw { get { return new Vector<T>(y, x, y, w); } }
        public Vector<T> yxzx { get { return new Vector<T>(y, x, z, x); } }
        public Vector<T> yxzy { get { return new Vector<T>(y, x, z, y); } }
        public Vector<T> yxzz { get { return new Vector<T>(y, x, z, z); } }
        public Vector<T> yxzw { get { return new Vector<T>(y, x, z, w); } }
        public Vector<T> yxwx { get { return new Vector<T>(y, x, w, x); } }
        public Vector<T> yxwy { get { return new Vector<T>(y, x, w, y); } }
        public Vector<T> yxwz { get { return new Vector<T>(y, x, w, z); } }
        public Vector<T> yxww { get { return new Vector<T>(y, x, w, w); } }
        public Vector<T> yyxx { get { return new Vector<T>(y, y, x, x); } }
        public Vector<T> yyxy { get { return new Vector<T>(y, y, x, y); } }
        public Vector<T> yyxz { get { return new Vector<T>(y, y, x, z); } }
        public Vector<T> yyxw { get { return new Vector<T>(y, y, x, w); } }
        public Vector<T> yyyx { get { return new Vector<T>(y, y, y, x); } }
        public Vector<T> yyyy { get { return new Vector<T>(y, y, y, y); } }
        public Vector<T> yyyz { get { return new Vector<T>(y, y, y, z); } }
        public Vector<T> yyyw { get { return new Vector<T>(y, y, y, w); } }
        public Vector<T> yyzx { get { return new Vector<T>(y, y, z, x); } }
        public Vector<T> yyzy { get { return new Vector<T>(y, y, z, y); } }
        public Vector<T> yyzz { get { return new Vector<T>(y, y, z, z); } }
        public Vector<T> yyzw { get { return new Vector<T>(y, y, z, w); } }
        public Vector<T> yywx { get { return new Vector<T>(y, y, w, x); } }
        public Vector<T> yywy { get { return new Vector<T>(y, y, w, y); } }
        public Vector<T> yywz { get { return new Vector<T>(y, y, w, z); } }
        public Vector<T> yyww { get { return new Vector<T>(y, y, w, w); } }
        public Vector<T> yzxx { get { return new Vector<T>(y, z, x, x); } }
        public Vector<T> yzxy { get { return new Vector<T>(y, z, x, y); } }
        public Vector<T> yzxz { get { return new Vector<T>(y, z, x, z); } }
        public Vector<T> yzxw { get { return new Vector<T>(y, z, x, w); } }
        public Vector<T> yzyx { get { return new Vector<T>(y, z, y, x); } }
        public Vector<T> yzyy { get { return new Vector<T>(y, z, y, y); } }
        public Vector<T> yzyz { get { return new Vector<T>(y, z, y, z); } }
        public Vector<T> yzyw { get { return new Vector<T>(y, z, y, w); } }
        public Vector<T> yzzx { get { return new Vector<T>(y, z, z, x); } }
        public Vector<T> yzzy { get { return new Vector<T>(y, z, z, y); } }
        public Vector<T> yzzz { get { return new Vector<T>(y, z, z, z); } }
        public Vector<T> yzzw { get { return new Vector<T>(y, z, z, w); } }
        public Vector<T> yzwx { get { return new Vector<T>(y, z, w, x); } }
        public Vector<T> yzwy { get { return new Vector<T>(y, z, w, y); } }
        public Vector<T> yzwz { get { return new Vector<T>(y, z, w, z); } }
        public Vector<T> yzww { get { return new Vector<T>(y, z, w, w); } }
        public Vector<T> ywxx { get { return new Vector<T>(y, w, x, x); } }
        public Vector<T> ywxy { get { return new Vector<T>(y, w, x, y); } }
        public Vector<T> ywxz { get { return new Vector<T>(y, w, x, z); } }
        public Vector<T> ywxw { get { return new Vector<T>(y, w, x, w); } }
        public Vector<T> ywyx { get { return new Vector<T>(y, w, y, x); } }
        public Vector<T> ywyy { get { return new Vector<T>(y, w, y, y); } }
        public Vector<T> ywyz { get { return new Vector<T>(y, w, y, z); } }
        public Vector<T> ywyw { get { return new Vector<T>(y, w, y, w); } }
        public Vector<T> ywzx { get { return new Vector<T>(y, w, z, x); } }
        public Vector<T> ywzy { get { return new Vector<T>(y, w, z, y); } }
        public Vector<T> ywzz { get { return new Vector<T>(y, w, z, z); } }
        public Vector<T> ywzw { get { return new Vector<T>(y, w, z, w); } }
        public Vector<T> ywwx { get { return new Vector<T>(y, w, w, x); } }
        public Vector<T> ywwy { get { return new Vector<T>(y, w, w, y); } }
        public Vector<T> ywwz { get { return new Vector<T>(y, w, w, z); } }
        public Vector<T> ywww { get { return new Vector<T>(y, w, w, w); } }
        public Vector<T> zxxx { get { return new Vector<T>(z, x, x, x); } }
        public Vector<T> zxxy { get { return new Vector<T>(z, x, x, y); } }
        public Vector<T> zxxz { get { return new Vector<T>(z, x, x, z); } }
        public Vector<T> zxxw { get { return new Vector<T>(z, x, x, w); } }
        public Vector<T> zxyx { get { return new Vector<T>(z, x, y, x); } }
        public Vector<T> zxyy { get { return new Vector<T>(z, x, y, y); } }
        public Vector<T> zxyz { get { return new Vector<T>(z, x, y, z); } }
        public Vector<T> zxyw { get { return new Vector<T>(z, x, y, w); } }
        public Vector<T> zxzx { get { return new Vector<T>(z, x, z, x); } }
        public Vector<T> zxzy { get { return new Vector<T>(z, x, z, y); } }
        public Vector<T> zxzz { get { return new Vector<T>(z, x, z, z); } }
        public Vector<T> zxzw { get { return new Vector<T>(z, x, z, w); } }
        public Vector<T> zxwx { get { return new Vector<T>(z, x, w, x); } }
        public Vector<T> zxwy { get { return new Vector<T>(z, x, w, y); } }
        public Vector<T> zxwz { get { return new Vector<T>(z, x, w, z); } }
        public Vector<T> zxww { get { return new Vector<T>(z, x, w, w); } }
        public Vector<T> zyxx { get { return new Vector<T>(z, y, x, x); } }
        public Vector<T> zyxy { get { return new Vector<T>(z, y, x, y); } }
        public Vector<T> zyxz { get { return new Vector<T>(z, y, x, z); } }
        public Vector<T> zyxw { get { return new Vector<T>(z, y, x, w); } }
        public Vector<T> zyyx { get { return new Vector<T>(z, y, y, x); } }
        public Vector<T> zyyy { get { return new Vector<T>(z, y, y, y); } }
        public Vector<T> zyyz { get { return new Vector<T>(z, y, y, z); } }
        public Vector<T> zyyw { get { return new Vector<T>(z, y, y, w); } }
        public Vector<T> zyzx { get { return new Vector<T>(z, y, z, x); } }
        public Vector<T> zyzy { get { return new Vector<T>(z, y, z, y); } }
        public Vector<T> zyzz { get { return new Vector<T>(z, y, z, z); } }
        public Vector<T> zyzw { get { return new Vector<T>(z, y, z, w); } }
        public Vector<T> zywx { get { return new Vector<T>(z, y, w, x); } }
        public Vector<T> zywy { get { return new Vector<T>(z, y, w, y); } }
        public Vector<T> zywz { get { return new Vector<T>(z, y, w, z); } }
        public Vector<T> zyww { get { return new Vector<T>(z, y, w, w); } }
        public Vector<T> zzxx { get { return new Vector<T>(z, z, x, x); } }
        public Vector<T> zzxy { get { return new Vector<T>(z, z, x, y); } }
        public Vector<T> zzxz { get { return new Vector<T>(z, z, x, z); } }
        public Vector<T> zzxw { get { return new Vector<T>(z, z, x, w); } }
        public Vector<T> zzyx { get { return new Vector<T>(z, z, y, x); } }
        public Vector<T> zzyy { get { return new Vector<T>(z, z, y, y); } }
        public Vector<T> zzyz { get { return new Vector<T>(z, z, y, z); } }
        public Vector<T> zzyw { get { return new Vector<T>(z, z, y, w); } }
        public Vector<T> zzzx { get { return new Vector<T>(z, z, z, x); } }
        public Vector<T> zzzy { get { return new Vector<T>(z, z, z, y); } }
        public Vector<T> zzzz { get { return new Vector<T>(z, z, z, z); } }
        public Vector<T> zzzw { get { return new Vector<T>(z, z, z, w); } }
        public Vector<T> zzwx { get { return new Vector<T>(z, z, w, x); } }
        public Vector<T> zzwy { get { return new Vector<T>(z, z, w, y); } }
        public Vector<T> zzwz { get { return new Vector<T>(z, z, w, z); } }
        public Vector<T> zzww { get { return new Vector<T>(z, z, w, w); } }
        public Vector<T> zwxx { get { return new Vector<T>(z, w, x, x); } }
        public Vector<T> zwxy { get { return new Vector<T>(z, w, x, y); } }
        public Vector<T> zwxz { get { return new Vector<T>(z, w, x, z); } }
        public Vector<T> zwxw { get { return new Vector<T>(z, w, x, w); } }
        public Vector<T> zwyx { get { return new Vector<T>(z, w, y, x); } }
        public Vector<T> zwyy { get { return new Vector<T>(z, w, y, y); } }
        public Vector<T> zwyz { get { return new Vector<T>(z, w, y, z); } }
        public Vector<T> zwyw { get { return new Vector<T>(z, w, y, w); } }
        public Vector<T> zwzx { get { return new Vector<T>(z, w, z, x); } }
        public Vector<T> zwzy { get { return new Vector<T>(z, w, z, y); } }
        public Vector<T> zwzz { get { return new Vector<T>(z, w, z, z); } }
        public Vector<T> zwzw { get { return new Vector<T>(z, w, z, w); } }
        public Vector<T> zwwx { get { return new Vector<T>(z, w, w, x); } }
        public Vector<T> zwwy { get { return new Vector<T>(z, w, w, y); } }
        public Vector<T> zwwz { get { return new Vector<T>(z, w, w, z); } }
        public Vector<T> zwww { get { return new Vector<T>(z, w, w, w); } }
        public Vector<T> wxxx { get { return new Vector<T>(w, x, x, x); } }
        public Vector<T> wxxy { get { return new Vector<T>(w, x, x, y); } }
        public Vector<T> wxxz { get { return new Vector<T>(w, x, x, z); } }
        public Vector<T> wxxw { get { return new Vector<T>(w, x, x, w); } }
        public Vector<T> wxyx { get { return new Vector<T>(w, x, y, x); } }
        public Vector<T> wxyy { get { return new Vector<T>(w, x, y, y); } }
        public Vector<T> wxyz { get { return new Vector<T>(w, x, y, z); } }
        public Vector<T> wxyw { get { return new Vector<T>(w, x, y, w); } }
        public Vector<T> wxzx { get { return new Vector<T>(w, x, z, x); } }
        public Vector<T> wxzy { get { return new Vector<T>(w, x, z, y); } }
        public Vector<T> wxzz { get { return new Vector<T>(w, x, z, z); } }
        public Vector<T> wxzw { get { return new Vector<T>(w, x, z, w); } }
        public Vector<T> wxwx { get { return new Vector<T>(w, x, w, x); } }
        public Vector<T> wxwy { get { return new Vector<T>(w, x, w, y); } }
        public Vector<T> wxwz { get { return new Vector<T>(w, x, w, z); } }
        public Vector<T> wxww { get { return new Vector<T>(w, x, w, w); } }
        public Vector<T> wyxx { get { return new Vector<T>(w, y, x, x); } }
        public Vector<T> wyxy { get { return new Vector<T>(w, y, x, y); } }
        public Vector<T> wyxz { get { return new Vector<T>(w, y, x, z); } }
        public Vector<T> wyxw { get { return new Vector<T>(w, y, x, w); } }
        public Vector<T> wyyx { get { return new Vector<T>(w, y, y, x); } }
        public Vector<T> wyyy { get { return new Vector<T>(w, y, y, y); } }
        public Vector<T> wyyz { get { return new Vector<T>(w, y, y, z); } }
        public Vector<T> wyyw { get { return new Vector<T>(w, y, y, w); } }
        public Vector<T> wyzx { get { return new Vector<T>(w, y, z, x); } }
        public Vector<T> wyzy { get { return new Vector<T>(w, y, z, y); } }
        public Vector<T> wyzz { get { return new Vector<T>(w, y, z, z); } }
        public Vector<T> wyzw { get { return new Vector<T>(w, y, z, w); } }
        public Vector<T> wywx { get { return new Vector<T>(w, y, w, x); } }
        public Vector<T> wywy { get { return new Vector<T>(w, y, w, y); } }
        public Vector<T> wywz { get { return new Vector<T>(w, y, w, z); } }
        public Vector<T> wyww { get { return new Vector<T>(w, y, w, w); } }
        public Vector<T> wzxx { get { return new Vector<T>(w, z, x, x); } }
        public Vector<T> wzxy { get { return new Vector<T>(w, z, x, y); } }
        public Vector<T> wzxz { get { return new Vector<T>(w, z, x, z); } }
        public Vector<T> wzxw { get { return new Vector<T>(w, z, x, w); } }
        public Vector<T> wzyx { get { return new Vector<T>(w, z, y, x); } }
        public Vector<T> wzyy { get { return new Vector<T>(w, z, y, y); } }
        public Vector<T> wzyz { get { return new Vector<T>(w, z, y, z); } }
        public Vector<T> wzyw { get { return new Vector<T>(w, z, y, w); } }
        public Vector<T> wzzx { get { return new Vector<T>(w, z, z, x); } }
        public Vector<T> wzzy { get { return new Vector<T>(w, z, z, y); } }
        public Vector<T> wzzz { get { return new Vector<T>(w, z, z, z); } }
        public Vector<T> wzzw { get { return new Vector<T>(w, z, z, w); } }
        public Vector<T> wzwx { get { return new Vector<T>(w, z, w, x); } }
        public Vector<T> wzwy { get { return new Vector<T>(w, z, w, y); } }
        public Vector<T> wzwz { get { return new Vector<T>(w, z, w, z); } }
        public Vector<T> wzww { get { return new Vector<T>(w, z, w, w); } }
        public Vector<T> wwxx { get { return new Vector<T>(w, w, x, x); } }
        public Vector<T> wwxy { get { return new Vector<T>(w, w, x, y); } }
        public Vector<T> wwxz { get { return new Vector<T>(w, w, x, z); } }
        public Vector<T> wwxw { get { return new Vector<T>(w, w, x, w); } }
        public Vector<T> wwyx { get { return new Vector<T>(w, w, y, x); } }
        public Vector<T> wwyy { get { return new Vector<T>(w, w, y, y); } }
        public Vector<T> wwyz { get { return new Vector<T>(w, w, y, z); } }
        public Vector<T> wwyw { get { return new Vector<T>(w, w, y, w); } }
        public Vector<T> wwzx { get { return new Vector<T>(w, w, z, x); } }
        public Vector<T> wwzy { get { return new Vector<T>(w, w, z, y); } }
        public Vector<T> wwzz { get { return new Vector<T>(w, w, z, z); } }
        public Vector<T> wwzw { get { return new Vector<T>(w, w, z, w); } }
        public Vector<T> wwwx { get { return new Vector<T>(w, w, w, x); } }
        public Vector<T> wwwy { get { return new Vector<T>(w, w, w, y); } }
        public Vector<T> wwwz { get { return new Vector<T>(w, w, w, z); } }
        public Vector<T> wwww { get { return new Vector<T>(w, w, w, w); } }
    }
}