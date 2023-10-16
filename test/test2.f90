!=============================================================================================
! Project name: test2
! Project version: aaa
!---------------------------------------------------------------------------------------------
! Generated by Aqualis (algorithm and equation analyzer for lightwave simulation)
! Aqualis version: aaa
! Generated date: 2023/10/16 14:10:41
!=============================================================================================
program test2
implicit none
complex(kind(0d0)) :: uj=(0d0,1d0)
integer :: tab=2313
integer(1) :: byte_tmp
character(100) :: t001
integer :: f001=11
integer :: ic001
integer :: ic002
integer :: i001
integer :: i002
double precision :: d001
double precision :: d002
double precision :: d003
double precision :: d004
complex(kind(0d0)) :: z001
complex(kind(0d0)) :: z002
double precision,allocatable :: d1001(:)
integer :: d1001_size(1:1)=(/ -1 /)
double precision,allocatable :: d1002(:)
integer :: d1002_size(1:1)=(/ -1 /)
double precision,allocatable :: d1003(:)
integer :: d1003_size(1:1)=(/ -1 /)
double precision,allocatable :: d2001(:,:)
integer :: d2001_size(1:2)=(/ -1,-1 /)
double precision,allocatable :: d2002(:,:)
integer :: d2002_size(1:2)=(/ -1,-1 /)
double precision,allocatable :: d2003(:,:)
integer :: d2003_size(1:2)=(/ -1,-1 /)
!%%%test1%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
  !001
  i002 = 1
  !002
  i001 = i002+1
  !003
  i001 = i001+i002
  !004
  i001 = (i001+i002)*(i001+i002)
  !005
  d001 = 1
  !006
  d002 = d001/d002/d002
  !007
  i001 = i001-i002
  !008
  d001 = i001/i002
  !009
  i001 = i001/i002
  !010
  print *, i002
  print *, i002
  print *, i002+1
  !011
  i002 = -1
  !012
  i001 = 1-i002
  !013
  i001 = i002-i001
  !014
  i001 = -(i001+i002)*(i001+i002)
  !015
  d001 = -1
  !016
  d002 = -d001/d002/d002
  !017
  i001 = -(i001+i002)
  !018
  d001 = -i001/i002
  !019
  i001 = -i001/i002
  !020
  d002 = sin(-(d001+d002)/d001)
  d002 = cos(d001)
  d002 = tan(d001)
  d002 = exp(d001)
  d002 = log(d001)
  d002 = log10(d001)
  d002 = sqrt(d001)
  d002 = asin(d001)
  d002 = acos(d001)
  d002 = atan(d001)
  d002 = atan2(d001,d002)
  d002 = floor(d001)
  d002 = ceiling(d001)
!%%%end test1%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
!%%%test2%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
  d1001_size(1) = 10
  allocate(d1001(1:d1001_size(1)))
  d1002_size(1) = 10
  allocate(d1002(1:d1002_size(1)))
  d1003_size(1) = 10
  allocate(d1003(1:d1003_size(1)))
  !021
  do ic001=1,d1003_size(1)
    d1003(ic001) = d1001(ic001)+d1002(ic001)
  end do
  !022
  do ic001=1,3
    d1003(ic001) = d1001(ic001+3)+d1002(ic001+3)
  end do
  !023
  do ic001=1,d1003_size(1)
    d1003(ic001) = d1001(ic001)*(d1001(ic001)+d1002(ic001))
  end do
  d1003_size(1) = -1
  deallocate(d1003)
  d2001_size(1) = 10
  d2001_size(2) = 5
  allocate(d2001(1:d2001_size(1),2:d2001_size(1)))
  d2002_size(1) = 10
  d2002_size(2) = 5
  allocate(d2002(1:d2002_size(1),2:d2002_size(1)))
  d2003_size(1) = 10
  d2003_size(2) = 5
  allocate(d2003(1:d2003_size(1),2:d2003_size(1)))
  !024
  do ic001=1,d2003_size(1)
    do ic002=1,d2003_size(2)
      d2003(ic001,ic002) = d2001(ic001,ic002)+d2002(ic001,ic002)
    end do
  end do
  !025
  do ic001=1,3
    d2003(ic001,3) = d2001(ic001+3,3)+d2002(ic001+3,3)
  end do
  !026
  do ic001=1,d2003_size(1)
    do ic002=1,d2003_size(2)
      d2003(ic001,ic002) = d2001(ic001,ic002)*(d2001(ic001,ic002)+d2002(ic001,ic002))
    end do
  end do
  !027
  i001 = 1
  write(t001,"(A,I8,A)") "test",i001,".dat"
  do ic001 = 1, len_trim(t001)
    if ( t001( ic001:ic001 ).EQ." " ) t001( ic001:ic001 ) = "0"
  end do
  open(f001, file=trim(t001))
  write(f001,"(I8,A1,I8,A1,I8)") i001
  write(f001,"(I8,A1,I8,A1,I8)") 
  close(f001)
  !028
  i001 = 1
  i002 = 1
  i002 = 8*i001
  !aaa
  d001 = 2*i001
  !bbb
  i002 = 2*i001
  !ccc
  d1002_size(1) = -1
  deallocate(d1002)
  d1001_size(1) = -1
  deallocate(d1001)
!%%%end test2%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
!%%%test3%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
  !001
  i001 = 2*i001
  !002
  i001 = 0
  !003
  d001 = 1
  !004
  i001 = 1
  !005
  d001 = 2*(i001+d001)
  !006
  d001 = 4*i001
  !007
  d001 = 0
  !008
  d001 = 0
  !009
  d001 = 1
  !010
  d001 = 1
  !011
  d001 = 1
  !test4851
  d003 = 1.5
  d004 = 8.4
  d001 = 2.377358490566038
  d002 = 1.5849056603773586*d003
  print *, 4851
  print *, d001
  print *, d002
  print *, abs(d001-d002)
!%%%end test3%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
!%%%test4%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
  !001
  i001 = -2
  d001 = sin(dble(i001))
  print *, d001
  d001 = cos(dble(i001))
  print *, d001
  d001 = tan(dble(i001))
  print *, d001
  d001 = exp(dble(i001))
  print *, d001
  d001 = log(dble(i001))
  print *, d001
  d001 = log10(dble(i001))
  print *, d001
  d001 = sqrt(dble(i001))
  print *, d001
  d001 = asin(dble(i001))
  print *, d001
  d001 = acos(dble(i001))
  print *, d001
  d001 = atan(dble(i001))
  print *, d001
  d001 = atan2(dble(i001),d001)
  print *, d001
  !002
  d001 = 1.2
  d003 = sin(d001)
  print *, d003
  d003 = cos(d001)
  print *, d003
  d003 = tan(d001)
  print *, d003
  d003 = exp(d001)
  print *, d003
  d003 = log(d001)
  print *, d003
  d003 = log10(d001)
  print *, d003
  d003 = sqrt(d001)
  print *, d003
  d003 = asin(d001)
  print *, d003
  d003 = acos(d001)
  print *, d003
  d003 = atan(d001)
  print *, d003
  d003 = atan2(d001,d002)
  print *, d003
  d003 = floor(d001)
  print *, d003
  d003 = ceiling(d001)
  print *, d003
  !003
  z001 = 1-uj*2
  z002 = sin(z001)
  print *, real(z002),aimag(z002)
  z002 = cos(z001)
  print *, real(z002),aimag(z002)
  z002 = tan(z001)
  print *, real(z002),aimag(z002)
  z002 = exp(z001)
  print *, real(z002),aimag(z002)
  z002 = log(z001)
  print *, real(z002),aimag(z002)
  z002 = sqrt(z001)
  print *, real(z002),aimag(z002)
  z002 = asin(z001)
  print *, real(z002),aimag(z002)
  z002 = acos(z001)
  print *, real(z002),aimag(z002)
  z002 = atan(z001)
  print *, real(z002),aimag(z002)
!%%%end test4%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

contains

end program test2
