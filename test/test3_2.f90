!=============================================================================================
! Project name: test3_2
! Project version: aaa
!---------------------------------------------------------------------------------------------
! Generated by Aqualis (algorithm and equation analyzer for lightwave simulation)
! Aqualis version: aaa
! Generated date: 2023/10/16 13:32:35
!=============================================================================================
program test3_2
implicit none
type testClass1
  integer :: n1
  double precision :: x1
  complex(kind(0d0)) :: z1
end type testClass1
type testClass2
  type(testClass1) :: s2
  type(testClass1),allocatable :: t2(:)
  integer :: t2_size(1:1)
end type testClass2
complex(kind(0d0)) :: uj=(0d0,1d0)
type(testClass2),allocatable :: q(:)
integer :: q_size(1:1)=(/ -1 /)
type(testClass2) :: p
integer,allocatable :: xx(:)
integer :: xx_size(1:1)=(/ -1 /)
type(testClass1),allocatable :: d(:)
integer :: d_size(1:1)=(/ -1 /)
type(testClass1) :: c
integer :: ic001
integer,allocatable :: i1001(:)
integer :: i1001_size(1:1)=(/ -1 /)
d_size(1) = 4
allocate(d(1:d_size(1)))
xx_size(1) = 8
allocate(xx(1:xx_size(1)))
q_size(1) = 5
allocate(q(1:q_size(1)))
p%s2%n1 = 100
p%s2%x1 = 200
p%s2%z1 = 300+uj*400
p%t2_size(1) = 3
allocate(p%t2(1:p%t2_size(1)))
q(1)%t2_size(1) = 2
allocate(q(1)%t2(1:q(1)%t2_size(1)))
q(1)%t2(2)%n1 = 2000
p%t2(1)%n1 = 1000
do ic001=1,d_size(1)
  d(ic001)%n1 = 1
  d(ic001)%x1 = 2
  d(ic001)%z1 = 3+uj*4
end do
i1001_size(1) = 10
allocate(i1001(1:i1001_size(1)))
i1001(1) = 1
i1001(2) = 2
i1001(3) = 3
i1001(4) = 4
i1001_size(1) = -1
deallocate(i1001)
i1001_size(1) = 20
allocate(i1001(1:i1001_size(1)))
i1001(1) = 1
i1001(2) = 2
i1001(3) = 3
i1001(4) = 4
i1001_size(1) = -1
deallocate(i1001)
print *, p%s2%n1
print *, p%s2%x1
print *, real(p%s2%z1),aimag(p%s2%z1)

contains

end program test3_2
