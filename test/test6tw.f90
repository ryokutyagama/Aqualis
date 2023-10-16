!=============================================================================================
! Project name: test6tw
! Project version: aaa
!---------------------------------------------------------------------------------------------
! Generated by Aqualis (algorithm and equation analyzer for lightwave simulation)
! Aqualis version: aaa
! Generated date: 2023/10/17 2:41:20
!=============================================================================================
program test6tw
implicit none
integer :: tab=2313
integer(1) :: byte_tmp
character(100) :: t001
integer :: f001=11
complex(kind(0d0)) :: uj=(0d0,1d0)
integer :: ic001
integer :: i001
integer :: i002
double precision :: d001
complex(kind(0d0)) :: z001
i001 = 1
i002 = 2
d001 = 1.234d0
z001 = 5.6d0+uj*7.8d0
write(t001,"(A,I8,A,I8,A)") "testA",i001,"_",i002,".dat"
do ic001 = 1, len_trim(t001)
  if ( t001( ic001:ic001 ).EQ." " ) t001( ic001:ic001 ) = "0"
end do
open(f001, file=trim(t001))
write(f001,"(I8,A1,I8,A1,I8)") i001,tab,i001+1,tab,i001+2
write(f001,"(I8,A1,I8,A1,I8)") i001+3,tab,i001+4,tab,i001+5
write(f001,"(E27.17e3,A1,E27.17e3,A1,E27.17e3)") d001,tab,real(z001),tab,aimag(z001)
write(f001,"(E27.17e3,A1,E27.17e3,A1,E27.17e3)") sin(d001),tab,real(exp(z001)),tab,aimag(exp(z001))
write(f001,"(E27.17e3)") d001+cos(d001)
write(f001,"(E27.17e3,A1,E27.17e3)") abs(z001),tab,abs(z001)**2
close(f001)

contains

end program test6tw
