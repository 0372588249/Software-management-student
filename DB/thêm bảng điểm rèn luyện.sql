USE QUANLYSV
GO



SELECT (diem_ren_luyen_ki_1 + diem_ren_luyen_ki_2 + diem_ren_luyen_ki_3 
		+ diem_ren_luyen_ki_4 + diem_ren_luyen_ki_5 + diem_ren_luyen_ki_6 
		+ diem_ren_luyen_ki_7 + diem_ren_luyen_ki_8 + diem_ren_luyen_ki_9)/9 FROM SINH_VIEN, DIEM_REN_LUYEN
WHERE SINH_VIEN.ma_sv = DIEM_REN_LUYEN.ma_sv
AND (diem_ren_luyen_ki_1 + diem_ren_luyen_ki_2 + diem_ren_luyen_ki_3 
		+ diem_ren_luyen_ki_4 + diem_ren_luyen_ki_5 + diem_ren_luyen_ki_6 
		+ diem_ren_luyen_ki_7 + diem_ren_luyen_ki_8 + diem_ren_luyen_ki_9)/9 >= 80
AND (diem_ren_luyen_ki_1 + diem_ren_luyen_ki_2 + diem_ren_luyen_ki_3 
		+ diem_ren_luyen_ki_4 + diem_ren_luyen_ki_5 + diem_ren_luyen_ki_6 
		+ diem_ren_luyen_ki_7 + diem_ren_luyen_ki_8 + diem_ren_luyen_ki_9)/9 < 90